namespace WindowsFormsApp4
{
    partial class Aktualny_kurs
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label_euro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_gbp = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label_usd = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel4 = new System.Windows.Forms.Panel();
            this.b_LoadEUR = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.b_LoadGBP = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.b_LoadUSD = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.label_euro);
            this.panel2.Controls.Add(this.bunifuSeparator1);
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(48, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 97);
            this.panel2.TabIndex = 1;
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_euro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.label_euro.Location = new System.Drawing.Point(16, 59);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(44, 15);
            this.label_euro.TabIndex = 2;
            this.label_euro.Text = "label";
            this.label_euro.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(19, 37);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(69, 19);
            this.bunifuSeparator1.TabIndex = 1;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 19);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(40, 15);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "EUR";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label_gbp);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Location = new System.Drawing.Point(224, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 97);
            this.panel1.TabIndex = 2;
            // 
            // label_gbp
            // 
            this.label_gbp.AutoSize = true;
            this.label_gbp.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_gbp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.label_gbp.Location = new System.Drawing.Point(16, 59);
            this.label_gbp.Name = "label_gbp";
            this.label_gbp.Size = new System.Drawing.Size(44, 15);
            this.label_gbp.TabIndex = 2;
            this.label_gbp.Text = "label";
            this.label_gbp.Click += new System.EventHandler(this.label_gbp_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(19, 37);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(69, 19);
            this.bunifuSeparator2.TabIndex = 1;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(31, 19);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(40, 15);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "GBP";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkViolet;
            this.panel3.Controls.Add(this.label_usd);
            this.panel3.Controls.Add(this.bunifuSeparator3);
            this.panel3.Controls.Add(this.bunifuCustomLabel6);
            this.panel3.Location = new System.Drawing.Point(407, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 97);
            this.panel3.TabIndex = 3;
            // 
            // label_usd
            // 
            this.label_usd.AutoSize = true;
            this.label_usd.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_usd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.label_usd.Location = new System.Drawing.Point(16, 59);
            this.label_usd.Name = "label_usd";
            this.label_usd.Size = new System.Drawing.Size(44, 15);
            this.label_usd.TabIndex = 2;
            this.label_usd.Text = "label";
            this.label_usd.Click += new System.EventHandler(this.label_usd_Click);
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(19, 37);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(69, 19);
            this.bunifuSeparator3.TabIndex = 1;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Swis721 Ex BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(69)))));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(31, 19);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(42, 15);
            this.bunifuCustomLabel6.TabIndex = 1;
            this.bunifuCustomLabel6.Text = "USD";
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(27, 150);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(548, 35);
            this.bunifuSeparator4.TabIndex = 4;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CadetBlue;
            this.panel4.Controls.Add(this.b_LoadEUR);
            this.panel4.Location = new System.Drawing.Point(48, 191);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 42);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // b_LoadEUR
            // 
            this.b_LoadEUR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_LoadEUR.ButtonText = "Wyświetl wykres";
            this.b_LoadEUR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_LoadEUR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_LoadEUR.ForeColor = System.Drawing.Color.Black;
            this.b_LoadEUR.ForeColorHoverState = System.Drawing.Color.White;
            this.b_LoadEUR.Iconimage = null;
            this.b_LoadEUR.IconVisible = true;
            this.b_LoadEUR.IconZoom = 90D;
            this.b_LoadEUR.ImageIconOverlay = false;
            this.b_LoadEUR.Location = new System.Drawing.Point(-45, 3);
            this.b_LoadEUR.Name = "b_LoadEUR";
            this.b_LoadEUR.Size = new System.Drawing.Size(173, 36);
            this.b_LoadEUR.TabIndex = 11;
            this.b_LoadEUR.Click += new System.EventHandler(this.b_LoadChart_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Controls.Add(this.b_LoadGBP);
            this.panel5.Location = new System.Drawing.Point(48, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(110, 42);
            this.panel5.TabIndex = 6;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // b_LoadGBP
            // 
            this.b_LoadGBP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_LoadGBP.ButtonText = "Wyświetl wykres";
            this.b_LoadGBP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_LoadGBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_LoadGBP.ForeColor = System.Drawing.Color.Black;
            this.b_LoadGBP.ForeColorHoverState = System.Drawing.Color.White;
            this.b_LoadGBP.Iconimage = null;
            this.b_LoadGBP.IconVisible = true;
            this.b_LoadGBP.IconZoom = 90D;
            this.b_LoadGBP.ImageIconOverlay = false;
            this.b_LoadGBP.Location = new System.Drawing.Point(-48, 3);
            this.b_LoadGBP.Name = "b_LoadGBP";
            this.b_LoadGBP.Size = new System.Drawing.Size(177, 36);
            this.b_LoadGBP.TabIndex = 12;
            this.b_LoadGBP.Click += new System.EventHandler(this.b_LoadGBP_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkViolet;
            this.panel6.Controls.Add(this.b_LoadUSD);
            this.panel6.Location = new System.Drawing.Point(48, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(110, 42);
            this.panel6.TabIndex = 6;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // b_LoadUSD
            // 
            this.b_LoadUSD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.b_LoadUSD.ButtonText = "Wyświetl wykres";
            this.b_LoadUSD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_LoadUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_LoadUSD.ForeColor = System.Drawing.Color.Black;
            this.b_LoadUSD.ForeColorHoverState = System.Drawing.Color.White;
            this.b_LoadUSD.Iconimage = null;
            this.b_LoadUSD.IconVisible = true;
            this.b_LoadUSD.IconZoom = 90D;
            this.b_LoadUSD.ImageIconOverlay = false;
            this.b_LoadUSD.Location = new System.Drawing.Point(-48, 3);
            this.b_LoadUSD.Name = "b_LoadUSD";
            this.b_LoadUSD.Size = new System.Drawing.Size(182, 36);
            this.b_LoadUSD.TabIndex = 13;
            this.b_LoadUSD.Click += new System.EventHandler(this.b_LoadUSD_Click);
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 1;
            this.bunifuSeparator5.Location = new System.Drawing.Point(164, 191);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(22, 138);
            this.bunifuSeparator5.TabIndex = 7;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = true;
            // 
            // chart1
            // 
            this.chart1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.chart1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            this.chart1.BorderlineColor = System.Drawing.Color.HotPink;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelAutoFitMinFontSize = 5;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(203, 191);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.CadetBlue,
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.DarkViolet};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "EUR";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "GBP";
            series3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "USD";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(372, 138);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Swis721 Ex BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(409, 404);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(73, 14);
            this.bunifuCustomLabel8.TabIndex = 10;
            this.bunifuCustomLabel8.Text = "l_datakursu";
            this.bunifuCustomLabel8.Click += new System.EventHandler(this.bunifuCustomLabel8_Click);
            // 
            // Aktualny_kurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.bunifuSeparator5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.bunifuSeparator4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Aktualny_kurs";
            this.Size = new System.Drawing.Size(607, 431);
            this.Load += new System.EventHandler(this.Aktualny_kurs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel label_euro;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel label_gbp;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel label_usd;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        protected Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private WindowsFormsControlLibrary1.BunifuThinButton b_LoadEUR;
        private WindowsFormsControlLibrary1.BunifuThinButton b_LoadGBP;
        private WindowsFormsControlLibrary1.BunifuThinButton b_LoadUSD;
    }
}
