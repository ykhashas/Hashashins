namespace Hashashins_CRM.Formlar
{
    partial class Personeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personeller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.MailText = new DevExpress.XtraEditors.TextEdit();
            this.SoyadiText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Sil = new DevExpress.XtraEditors.SimpleButton();
            this.AdiText = new DevExpress.XtraEditors.TextEdit();
            this.IdText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Listele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 336);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.MailText);
            this.groupControl1.Controls.Add(this.SoyadiText);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.Guncelle);
            this.groupControl1.Controls.Add(this.Sil);
            this.groupControl1.Controls.Add(this.AdiText);
            this.groupControl1.Controls.Add(this.IdText);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Listele);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(657, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 336);
            this.groupControl1.TabIndex = 3;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(147, 156);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.NullText = "";
            this.lookUpEdit1.Size = new System.Drawing.Size(149, 22);
            this.lookUpEdit1.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 159);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(121, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Personel Departman:";
            // 
            // MailText
            // 
            this.MailText.Location = new System.Drawing.Point(147, 128);
            this.MailText.Name = "MailText";
            this.MailText.Size = new System.Drawing.Size(149, 22);
            this.MailText.TabIndex = 11;
            // 
            // SoyadiText
            // 
            this.SoyadiText.Location = new System.Drawing.Point(147, 100);
            this.SoyadiText.Name = "SoyadiText";
            this.SoyadiText.Size = new System.Drawing.Size(149, 22);
            this.SoyadiText.TabIndex = 10;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 131);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(81, 16);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Personel Mail:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 103);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(96, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Personel Soyadı:";
            // 
            // Guncelle
            // 
            this.Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Guncelle.ImageOptions.Image")));
            this.Guncelle.Location = new System.Drawing.Point(190, 210);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(106, 29);
            this.Guncelle.TabIndex = 7;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sil.ImageOptions.Image")));
            this.Sil.Location = new System.Drawing.Point(147, 245);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(106, 29);
            this.Sil.TabIndex = 6;
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // AdiText
            // 
            this.AdiText.Location = new System.Drawing.Point(147, 72);
            this.AdiText.Name = "AdiText";
            this.AdiText.Size = new System.Drawing.Size(149, 22);
            this.AdiText.TabIndex = 4;
            // 
            // IdText
            // 
            this.IdText.Enabled = false;
            this.IdText.Location = new System.Drawing.Point(147, 44);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(149, 22);
            this.IdText.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel Adı:";
            // 
            // Listele
            // 
            this.Listele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Listele.ImageOptions.Image")));
            this.Listele.Location = new System.Drawing.Point(79, 210);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(106, 29);
            this.Listele.TabIndex = 1;
            this.Listele.Text = "Listele";
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID:";
            // 
            // Personeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Personeller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Personeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MailText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoyadiText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Guncelle;
        private DevExpress.XtraEditors.SimpleButton Sil;
        private DevExpress.XtraEditors.TextEdit AdiText;
        private DevExpress.XtraEditors.TextEdit IdText;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Listele;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit MailText;
        private DevExpress.XtraEditors.TextEdit SoyadiText;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}