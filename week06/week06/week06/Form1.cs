﻿using System;
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
        BindingList<string> Currencies = new BindingList<string>();

        public Form1()
        {
            InitializeComponent();
            string xmlCurrenciesResult = GetCurrencies();
            FormatCurrenciesXml(xmlCurrenciesResult);
            RefreshData();
        }

        void RefreshData()
        {
            Rates.Clear();
            string xmlPriceResult = GetPriceData();

            ratesDataGridView.DataSource = Rates;            
            FormatPriceXml(xmlPriceResult);
            ShowChart();
        }

        string GetCurrencies()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var requestCurr = new GetCurrenciesRequestBody();
            var responseCurr = mnbService.GetCurrencies(requestCurr);
            var resultCurr = responseCurr.GetCurrenciesResult;
            return resultCurr;
        }

        void FormatCurrenciesXml(string xmlResult)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlResult);

            foreach (XmlElement item in xml.DocumentElement.ChildNodes[0])
            {
                Currencies.Add(item.InnerText);
            }
            currencyPicker.DataSource = Currencies;
        }

        string GetPriceData()
        {
            var mnbService = new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = currencyPicker.SelectedItem.ToString(),
                startDate = dateTimePickerStart.Value.ToString(),
                endDate = dateTimePickerEnd.Value.ToString()
            };

            var response = mnbService.GetExchangeRates(request);

            var result = response.GetExchangeRatesResult;

            return result;
        }

        void FormatPriceXml(string xmlResult)
        {
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(xmlResult);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var rd = new RateData();
                Rates.Add(rd);

                rd.Date = DateTime.Parse(item.GetAttribute("date"));

                var childElement = (XmlElement)item.ChildNodes[0];
                if (childElement == null)
                    continue;
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

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void currencyPicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
