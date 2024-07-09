namespace Hashashins_CRM.Formlar
{
    partial class Personelİstatistikleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personelİstatistikleri));
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
            this.Temizle = new DevExpress.XtraEditors.SimpleButton();
            this.PasifPersonel = new System.Windows.Forms.CheckBox();
            this.AktifPersonel = new System.Windows.Forms.CheckBox();
            this.ToplamPersonel = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.PersonelAdi = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Temizle
            // 
            this.Temizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Temizle.ImageOptions.Image")));
            this.Temizle.Location = new System.Drawing.Point(433, 3);
            this.Temizle.Name = "Temizle";
            this.Temizle.Size = new System.Drawing.Size(99, 29);
            this.Temizle.TabIndex = 8;
            this.Temizle.Text = "Temizle";
            this.Temizle.Click += new System.EventHandler(this.Temizle_Click);
            // 
            // PasifPersonel
            // 
            this.PasifPersonel.AutoSize = true;
            this.PasifPersonel.Location = new System.Drawing.Point(258, 11);
            this.PasifPersonel.Name = "PasifPersonel";
            this.PasifPersonel.Size = new System.Drawing.Size(169, 21);
            this.PasifPersonel.TabIndex = 7;
            this.PasifPersonel.Text = "Aktif Olmayan Personel";
            this.PasifPersonel.UseVisualStyleBackColor = true;
            this.PasifPersonel.CheckedChanged += new System.EventHandler(this.PasifPersonel_CheckedChanged);
            // 
            // AktifPersonel
            // 
            this.AktifPersonel.AutoSize = true;
            this.AktifPersonel.Location = new System.Drawing.Point(141, 11);
            this.AktifPersonel.Name = "AktifPersonel";
            this.AktifPersonel.Size = new System.Drawing.Size(111, 21);
            this.AktifPersonel.TabIndex = 6;
            this.AktifPersonel.Text = "Aktif Personel";
            this.AktifPersonel.UseVisualStyleBackColor = true;
            this.AktifPersonel.CheckedChanged += new System.EventHandler(this.AktifPersonel_CheckedChanged);
            // 
            // ToplamPersonel
            // 
            this.ToplamPersonel.AutoSize = true;
            this.ToplamPersonel.Location = new System.Drawing.Point(10, 12);
            this.ToplamPersonel.Name = "ToplamPersonel";
            this.ToplamPersonel.Size = new System.Drawing.Size(130, 21);
            this.ToplamPersonel.TabIndex = 5;
            this.ToplamPersonel.Text = "Toplam Personel";
            this.ToplamPersonel.UseVisualStyleBackColor = true;
            this.ToplamPersonel.CheckedChanged += new System.EventHandler(this.ToplamPersonel_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.AppearanceNameSerializable = "Gray";
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 39);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PaletteBaseColorNumber = 3;
            series2.Name = "Personel İstatistikleri";
            series2.View = pieSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(458, 296);
            this.chartControl1.TabIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(464, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(532, 296);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(779, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Personel Adı:";
            // 
            // PersonelAdi
            // 
            this.PersonelAdi.Location = new System.Drawing.Point(861, 9);
            this.PersonelAdi.Name = "PersonelAdi";
            this.PersonelAdi.Size = new System.Drawing.Size(125, 22);
            this.PersonelAdi.TabIndex = 12;
            this.PersonelAdi.EditValueChanged += new System.EventHandler(this.PersonelAdi_EditValueChanged);
            this.PersonelAdi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PersonelAdi_KeyPress);
            // 
            // Personelİstatistikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.PersonelAdi);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.Temizle);
            this.Controls.Add(this.PasifPersonel);
            this.Controls.Add(this.AktifPersonel);
            this.Controls.Add(this.ToplamPersonel);
            this.Name = "Personelİstatistikleri";
            this.Text = "Personel İstatistikleri";
            this.Load += new System.EventHandler(this.Formdeneme_Load);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PersonelAdi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton Temizle;
        private System.Windows.Forms.CheckBox PasifPersonel;
        private System.Windows.Forms.CheckBox AktifPersonel;
        private System.Windows.Forms.CheckBox ToplamPersonel;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit PersonelAdi;
    }
}