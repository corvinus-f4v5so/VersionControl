using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;
using week06.Entities;
using week06.MnbServiceReference;

namespace week06
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();

        public Form1()
        {
            InitializeComponent();
            string xmlResult = GetResult();
            
            ratesDataGridView.DataSource = Rates;
            FormatXml(xmlResult);
            ShowChart();
        }

        string GetResult()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-10-25"
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;
        }

        void FormatXml(string xmlResult)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlResult);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var rd = new RateData();
                Rates.Add(rd);

                rd.Date = DateTime.Parse(item.GetAttribute("date"));

                var childElement = (XmlElement)item.ChildNodes[0];
                rd.Currency = childElement.GetAttribute("curr");

                decimal unit = decimal.Parse(childElement.GetAttribute("unit"));
                decimal innerText = decimal.Parse(childElement.InnerText);
                rd.Value = (unit != 0) ? innerText / unit : innerText;
            }

        }

        void ShowChart()
        {
            chartRateData.DataSource = Rates;
            var chartSeries = chartRateData.Series[0];
            chartSeries.ChartType = SeriesChartType.Line;
            chartSeries.XValueMember = "Date";
            chartSeries.YValueMembers = "Value";
            chartSeries.BorderWidth = 2;

            var area = chartRateData.ChartAreas[0];
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            area.AxisY.IsStartedFromZero = false;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

        }
    }
}
