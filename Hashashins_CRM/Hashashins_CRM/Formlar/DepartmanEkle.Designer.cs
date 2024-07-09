namespace Hashashins_CRM.Formlar
{
    partial class DepartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmanEkle));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.AdiText = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl1.Controls.Add(this.Ekle);
            this.groupControl1.Controls.Add(this.AdiText);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 208);
            this.groupControl1.TabIndex = 2;
            // 
            // Ekle
            // 
            this.Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ekle.ImageOptions.Image")));
            this.Ekle.Location = new System.Drawing.Point(112, 93);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(149, 45);
            this.Ekle.TabIndex = 5;
            this.Ekle.Text = "Ekle";
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // AdiText
            // 
            this.AdiText.Location = new System.Drawing.Point(112, 53);
            this.AdiText.Name = "AdiText";
            this.AdiText.Size = new System.Drawing.Size(149, 22);
            this.AdiText.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Departman Adı: ";
            // 
            // DepartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 208);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("DepartmanEkle.IconOptions.Image")));
            this.Name = "DepartmanEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdiText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton Ekle;
        private DevExpress.XtraEditors.TextEdit AdiText;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}