
namespace week06
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ratesDataGridView = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.currencyPicker = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // ratesDataGridView
            // 
            this.ratesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ratesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratesDataGridView.Location = new System.Drawing.Point(12, 46);
            this.ratesDataGridView.Name = "ratesDataGridView";
            this.ratesDataGridView.RowHeadersWidth = 51;
            this.ratesDataGridView.RowTemplate.Height = 24;
            this.ratesDataGridView.Size = new System.Drawing.Size(392, 442);
            this.ratesDataGridView.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea5.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartRateData.Legends.Add(legend5);
            this.chartRateData.Location = new System.Drawing.Point(410, 46);
            this.chartRateData.Name = "chartRateData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartRateData.Series.Add(series5);
            this.chartRateData.Size = new System.Drawing.Size(705, 442);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(12, 12);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStart.TabIndex = 2;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(218, 12);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // currencyPicker
            // 
            this.currencyPicker.FormattingEnabled = true;
            this.currencyPicker.Items.AddRange(new object[] {
            "EUR"});
            this.currencyPicker.Location = new System.Drawing.Point(424, 12);
            this.currencyPicker.Name = "currencyPicker";
            this.currencyPicker.Size = new System.Drawing.Size(121, 24);
            this.currencyPicker.TabIndex = 4;
            this.currencyPicker.Text = "EUR";
            this.currencyPicker.SelectedIndexChanged += new System.EventHandler(this.currencyPicker_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 500);
            this.Controls.Add(this.currencyPicker);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.ratesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ratesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ratesDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox currencyPicker;
    }
}

