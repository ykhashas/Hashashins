namespace Hashashins_CRM.Formlar
{
    partial class Gorevİstatistikleri
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gorevİstatistikleri));
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.TamamlananGorevler = new System.Windows.Forms.CheckBox();
            this.AktifGorevler = new System.Windows.Forms.CheckBox();
            this.ToplamGorevler = new System.Windows.Forms.CheckBox();
            this.Temizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Gray";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 39);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 3;
            series1.Name = "Görev İstatistikleri";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(986, 296);
            this.chartControl1.TabIndex = 10;
            // 
            // TamamlananGorevler
            // 
            this.TamamlananGorevler.AutoSize = true;
            this.TamamlananGorevler.Location = new System.Drawing.Point(618, 7);
            this.TamamlananGorevler.Name = "TamamlananGorevler";
            this.TamamlananGorevler.Size = new System.Drawing.Size(163, 21);
            this.TamamlananGorevler.TabIndex = 14;
            this.TamamlananGorevler.Text = "Tamamlanan Görevler";
            this.TamamlananGorevler.UseVisualStyleBackColor = true;
            this.TamamlananGorevler.CheckedChanged += new System.EventHandler(this.TamamlananGorevler_CheckedChanged);
            // 
            // AktifGorevler
            // 
            this.AktifGorevler.AutoSize = true;
            this.AktifGorevler.Location = new System.Drawing.Point(399, 7);
            this.AktifGorevler.Name = "AktifGorevler";
            this.AktifGorevler.Size = new System.Drawing.Size(111, 21);
            this.AktifGorevler.TabIndex = 13;
            this.AktifGorevler.Text = "Aktif Görevler";
            this.AktifGorevler.UseVisualStyleBackColor = true;
            this.AktifGorevler.CheckedChanged += new System.EventHandler(this.AktifGorevler_CheckedChanged);
            // 
            // ToplamGorevler
            // 
            this.ToplamGorevler.AutoSize = true;
            this.ToplamGorevler.Location = new System.Drawing.Point(151, 7);
            this.ToplamGorevler.Name = "ToplamGorevler";
            this.ToplamGorevler.Size = new System.Drawing.Size(130, 21);
            this.ToplamGorevler.TabIndex = 12;
            this.ToplamGorevler.Text = "Toplam Görevler";
            this.ToplamGorevler.UseVisualStyleBackColor = true;
            this.ToplamGorevler.CheckedChanged += new System.EventHandler(this.ToplamGorevler_CheckedChanged);
            // 
            // Temizle
            // 
            this.Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temizle.ImageOptions.Image")));
            this.Temizle.Location = new System.Drawing.Point(887, 4);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(99, 29);
            this.Temizle.TabIndex = 16;
            this.Temizle.Text = "Temizle";
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // Gorevİstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.TamamlananGorevler);
            this.Controls.Add(this.AktifGorevler);
            this.Controls.Add(this.ToplamGorevler);
            this.Controls.Add(this.chartControl1);
            this.Name = "Gorevİstatistikleri";
            this.Text = "Görev İstatistikleri";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.CheckBox TamamlananGorevler;
        private System.Windows.Forms.CheckBox AktifGorevler;
        private System.Windows.Forms.CheckBox ToplamGorevler;
        private DevExpress.XtraEditors.SimpleButton Temizle;
    }
}