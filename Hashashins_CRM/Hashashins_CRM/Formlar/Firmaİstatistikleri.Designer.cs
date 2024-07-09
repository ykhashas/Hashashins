namespace Hashashins_CRM.Formlar
{
    partial class Firmaİstatistikleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firmaİstatistikleri));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            this.Temizle1 = new DevExpress.XtraEditors.SimpleButton();
            this.Istanbul = new System.Windows.Forms.CheckBox();
            this.IlSayisi = new System.Windows.Forms.CheckBox();
            this.ToplamFirmalar = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.Ankara = new System.Windows.Forms.CheckBox();
            this.İzmir = new System.Windows.Forms.CheckBox();
            this.Bursa = new System.Windows.Forms.CheckBox();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.Temizle2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            this.SuspendLayout();
            // 
            // Temizle1
            // 
            this.Temizle1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temizle1.ImageOptions.Image")));
            this.Temizle1.Location = new System.Drawing.Point(893, 3);
            this.Temizle1.Name = "Temizle1";
            this.Temizle1.Size = new System.Drawing.Size(99, 29);
            this.Temizle1.TabIndex = 21;
            this.Temizle1.Text = "Temizle";
            this.Temizle1.Click += new System.EventHandler(this.Temizle1_Click);
            // 
            // Istanbul
            // 
            this.Istanbul.AutoSize = true;
            this.Istanbul.Location = new System.Drawing.Point(506, 9);
            this.Istanbul.Name = "Istanbul";
            this.Istanbul.Size = new System.Drawing.Size(78, 21);
            this.Istanbul.TabIndex = 20;
            this.Istanbul.Text = "İstanbul";
            this.Istanbul.UseVisualStyleBackColor = true;
            this.Istanbul.CheckedChanged += new System.EventHandler(this.Istanbul_CheckedChanged);
            // 
            // IlSayisi
            // 
            this.IlSayisi.AutoSize = true;
            this.IlSayisi.Location = new System.Drawing.Point(144, 9);
            this.IlSayisi.Name = "IlSayisi";
            this.IlSayisi.Size = new System.Drawing.Size(133, 21);
            this.IlSayisi.TabIndex = 19;
            this.IlSayisi.Text = "İş Yapılan İl Sayısı";
            this.IlSayisi.UseVisualStyleBackColor = true;
            this.IlSayisi.CheckedChanged += new System.EventHandler(this.IlSayisi_CheckedChanged);
            // 
            // ToplamFirmalar
            // 
            this.ToplamFirmalar.AutoSize = true;
            this.ToplamFirmalar.Location = new System.Drawing.Point(12, 9);
            this.ToplamFirmalar.Name = "ToplamFirmalar";
            this.ToplamFirmalar.Size = new System.Drawing.Size(126, 21);
            this.ToplamFirmalar.TabIndex = 18;
            this.ToplamFirmalar.Text = "Toplam Firmalar";
            this.ToplamFirmalar.UseVisualStyleBackColor = true;
            this.ToplamFirmalar.CheckedChanged += new System.EventHandler(this.ToplamFirmalar_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Gray";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(-1, 41);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 3;
            series1.Name = "Firma İstatistikleri";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(495, 296);
            this.chartControl1.TabIndex = 17;
            // 
            // Ankara
            // 
            this.Ankara.AutoSize = true;
            this.Ankara.Location = new System.Drawing.Point(592, 9);
            this.Ankara.Name = "Ankara";
            this.Ankara.Size = new System.Drawing.Size(72, 21);
            this.Ankara.TabIndex = 22;
            this.Ankara.Text = "Ankara";
            this.Ankara.UseVisualStyleBackColor = true;
            this.Ankara.CheckedChanged += new System.EventHandler(this.Ankara_CheckedChanged);
            // 
            // İzmir
            // 
            this.İzmir.AutoSize = true;
            this.İzmir.Location = new System.Drawing.Point(670, 9);
            this.İzmir.Name = "İzmir";
            this.İzmir.Size = new System.Drawing.Size(59, 21);
            this.İzmir.TabIndex = 23;
            this.İzmir.Text = "İzmir";
            this.İzmir.UseVisualStyleBackColor = true;
            this.İzmir.CheckedChanged += new System.EventHandler(this.İzmir_CheckedChanged);
            // 
            // Bursa
            // 
            this.Bursa.AutoSize = true;
            this.Bursa.Location = new System.Drawing.Point(735, 9);
            this.Bursa.Name = "Bursa";
            this.Bursa.Size = new System.Drawing.Size(64, 21);
            this.Bursa.TabIndex = 24;
            this.Bursa.Text = "Bursa";
            this.Bursa.UseVisualStyleBackColor = true;
            this.Bursa.CheckedChanged += new System.EventHandler(this.Bursa_CheckedChanged);
            // 
            // chartControl2
            // 
            this.chartControl2.AppearanceNameSerializable = "Gray";
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = xyDiagram2;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(502, 41);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PaletteBaseColorNumber = 3;
            series2.Name = "İller";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl2.Size = new System.Drawing.Size(495, 296);
            this.chartControl2.TabIndex = 25;
            // 
            // Temizle2
            // 
            this.Temizle2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temizle2.ImageOptions.Image")));
            this.Temizle2.Location = new System.Drawing.Point(386, 3);
            this.Temizle2.Name = "Temizle2";
            this.Temizle2.Size = new System.Drawing.Size(99, 29);
            this.Temizle2.TabIndex = 26;
            this.Temizle2.Text = "Temizle";
            this.Temizle2.Click += new System.EventHandler(this.Temizle2_Click);
            // 
            // Firmaİstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.Temizle2);
            this.Controls.Add(this.chartControl2);
            this.Controls.Add(this.Bursa);
            this.Controls.Add(this.İzmir);
            this.Controls.Add(this.Ankara);
            this.Controls.Add(this.Temizle1);
            this.Controls.Add(this.Istanbul);
            this.Controls.Add(this.IlSayisi);
            this.Controls.Add(this.ToplamFirmalar);
            this.Controls.Add(this.chartControl1);
            this.Name = "Firmaİstatistikleri";
            this.Text = "Firma İstatistikleri";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Temizle1;
        private System.Windows.Forms.CheckBox Istanbul;
        private System.Windows.Forms.CheckBox IlSayisi;
        private System.Windows.Forms.CheckBox ToplamFirmalar;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.CheckBox Ankara;
        private System.Windows.Forms.CheckBox İzmir;
        private System.Windows.Forms.CheckBox Bursa;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private DevExpress.XtraEditors.SimpleButton Temizle2;
    }
}