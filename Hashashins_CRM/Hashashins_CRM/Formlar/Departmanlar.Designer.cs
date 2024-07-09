namespace Hashashins_CRM.Formlar
{
    partial class Departmanlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departmanlar));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.Sil = new DevExpress.XtraEditors.SimpleButton();
            this.AdiText = new DevExpress.XtraEditors.TextEdit();
            this.IdText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.Listele = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.groupControl1.TabIndex = 1;
            // 
            // Guncelle
            // 
            this.Guncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Guncelle.ImageOptions.Image")));
            this.Guncelle.Location = new System.Drawing.Point(126, 219);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(170, 29);
            this.Guncelle.TabIndex = 7;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Sil
            // 
            this.Sil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sil.ImageOptions.Image")));
            this.Sil.Location = new System.Drawing.Point(126, 184);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(170, 29);
            this.Sil.TabIndex = 6;
            this.Sil.Text = "Sil";
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // AdiText
            // 
            this.AdiText.Location = new System.Drawing.Point(126, 107);
            this.AdiText.Name = "AdiText";
            this.AdiText.Size = new System.Drawing.Size(170, 22);
            this.AdiText.TabIndex = 4;
            // 
            // IdText
            // 
            this.IdText.Enabled = false;
            this.IdText.Location = new System.Drawing.Point(126, 65);
            this.IdText.Name = "IdText";
            this.IdText.Size = new System.Drawing.Size(170, 22);
            this.IdText.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 110);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Departman Adı: ";
            // 
            // Listele
            // 
            this.Listele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Listele.ImageOptions.Image")));
            this.Listele.Location = new System.Drawing.Point(126, 149);
            this.Listele.Name = "Listele";
            this.Listele.Size = new System.Drawing.Size(170, 29);
            this.Listele.TabIndex = 1;
            this.Listele.Text = "Listele";
            this.Listele.Click += new System.EventHandler(this.Listele_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman ID: ";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(651, 336);
            this.gridControl1.TabIndex = 2;
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
            // Departmanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 337);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Departmanlar";
            this.Text = "Departmanlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Guncelle;
        private DevExpress.XtraEditors.SimpleButton Sil;
        private DevExpress.XtraEditors.TextEdit AdiText;
        private DevExpress.XtraEditors.TextEdit IdText;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton Listele;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}