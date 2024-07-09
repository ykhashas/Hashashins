namespace Hashashins_CRM.Formlar
{
    partial class Cagriİstatistikleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cagriİstatistikleri));
            DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            this.Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.TamamlananCagri = new System.Windows.Forms.CheckBox();
            this.AktifCagri = new System.Windows.Forms.CheckBox();
            this.ToplamCagri = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            this.SuspendLayout();
            // 
            // Temizle
            // 
            this.Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temizle.ImageOptions.Image")));
            this.Temizle.Location = new System.Drawing.Point(893, 3);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(99, 29);
            this.Temizle.TabIndex = 21;
            this.Temizle.Text = "Temizle";
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // TamamlananCagri
            // 
            this.TamamlananCagri.AutoSize = true;
            this.TamamlananCagri.Location = new System.Drawing.Point(624, 6);
            this.TamamlananCagri.Name = "TamamlananCagri";
            this.TamamlananCagri.Size = new System.Drawing.Size(157, 21);
            this.TamamlananCagri.TabIndex = 20;
            this.TamamlananCagri.Text = "Tamamlanan Çağrılar";
            this.TamamlananCagri.UseVisualStyleBackColor = true;
            this.TamamlananCagri.CheckedChanged += new System.EventHandler(this.TamamlananCagri_CheckedChanged);
            // 
            // AktifCagri
            // 
            this.AktifCagri.AutoSize = true;
            this.AktifCagri.Location = new System.Drawing.Point(405, 6);
            this.AktifCagri.Name = "AktifCagri";
            this.AktifCagri.Size = new System.Drawing.Size(105, 21);
            this.AktifCagri.TabIndex = 19;
            this.AktifCagri.Text = "Aktif Çağrılar";
            this.AktifCagri.UseVisualStyleBackColor = true;
            this.AktifCagri.CheckedChanged += new System.EventHandler(this.AktifCagri_CheckedChanged);
            // 
            // ToplamCagri
            // 
            this.ToplamCagri.AutoSize = true;
            this.ToplamCagri.Location = new System.Drawing.Point(157, 6);
            this.ToplamCagri.Name = "ToplamCagri";
            this.ToplamCagri.Size = new System.Drawing.Size(107, 21);
            this.ToplamCagri.TabIndex = 18;
            this.ToplamCagri.Text = "Tüm Çağrılar";
            this.ToplamCagri.UseVisualStyleBackColor = true;
            this.ToplamCagri.CheckedChanged += new System.EventHandler(this.ToplamCagri_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Gray";
            xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram3;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(6, 38);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 3;
            series3.Name = "Çağrı İstatistikleri";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl1.Size = new System.Drawing.Size(986, 296);
            this.chartControl1.TabIndex = 17;
            // 
            // Cagriİstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.TamamlananCagri);
            this.Controls.Add(this.AktifCagri);
            this.Controls.Add(this.ToplamCagri);
            this.Controls.Add(this.chartControl1);
            this.Name = "Cagriİstatistikleri";
            this.Text = "Çağrı İstatistikleri";
            ((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Temizle;
        private System.Windows.Forms.CheckBox TamamlananCagri;
        private System.Windows.Forms.CheckBox AktifCagri;
        private System.Windows.Forms.CheckBox ToplamCagri;
        private DevExpress.XtraCharts.ChartControl chartControl1;
    }
}