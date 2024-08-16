namespace GUI_QLTX
{
    partial class ThongKes
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pieNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pieThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colNam = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.colThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colThang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(904, 75);
            this.label1.TabIndex = 9;
            this.label1.Text = "THỐNG KÊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 75);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(904, 515);
            this.tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.colNam);
            this.tabPage1.Controls.Add(this.pieNam);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 482);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê theo năm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.cbThang);
            this.tabPage2.Controls.Add(this.colThang);
            this.tabPage2.Controls.Add(this.pieThang);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(896, 482);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê theo tháng";
            // 
            // pieNam
            // 
            chartArea5.Name = "ChartArea1";
            this.pieNam.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.pieNam.Legends.Add(legend5);
            this.pieNam.Location = new System.Drawing.Point(458, 6);
            this.pieNam.Name = "pieNam";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.pieNam.Series.Add(series5);
            this.pieNam.Size = new System.Drawing.Size(430, 369);
            this.pieNam.TabIndex = 11;
            this.pieNam.Text = "chart1";
            // 
            // pieThang
            // 
            chartArea6.Name = "ChartArea1";
            this.pieThang.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.pieThang.Legends.Add(legend6);
            this.pieThang.Location = new System.Drawing.Point(458, 78);
            this.pieThang.Name = "pieThang";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.pieThang.Series.Add(series6);
            this.pieThang.Size = new System.Drawing.Size(430, 369);
            this.pieThang.TabIndex = 12;
            this.pieThang.Text = "chart1";
            // 
            // colNam
            // 
            chartArea7.Name = "ChartArea1";
            this.colNam.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.colNam.Legends.Add(legend7);
            this.colNam.Location = new System.Drawing.Point(8, 6);
            this.colNam.Name = "colNam";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.colNam.Series.Add(series7);
            this.colNam.Size = new System.Drawing.Size(444, 369);
            this.colNam.TabIndex = 12;
            this.colNam.Text = "chart1";
            // 
            // colThang
            // 
            chartArea8.Name = "ChartArea1";
            this.colThang.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.colThang.Legends.Add(legend8);
            this.colThang.Location = new System.Drawing.Point(8, 78);
            this.colThang.Name = "colThang";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.colThang.Series.Add(series8);
            this.colThang.Size = new System.Drawing.Size(444, 369);
            this.colThang.TabIndex = 13;
            this.colThang.Text = "chart1";
            // 
            // cbThang
            // 
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(29, 32);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(121, 28);
            this.cbThang.TabIndex = 14;
            this.cbThang.SelectedIndexChanged += new System.EventHandler(this.cbThang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Thang";
            // 
            // ThongKes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 590);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.label1);
            this.Name = "ThongKes";
            this.Text = "ThongKes";
            this.Load += new System.EventHandler(this.ThongKes_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pieNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colThang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieNam;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart colNam;
        private System.Windows.Forms.DataVisualization.Charting.Chart colThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbThang;
    }
}