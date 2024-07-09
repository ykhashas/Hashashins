namespace Hashashins_CRM.Formlar
{
    partial class GorevEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GorevEkle));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Ekle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.AciklamaText = new DevExpress.XtraEditors.MemoEdit();
            this.TarihDate = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TamamlanmisRadio = new System.Windows.Forms.RadioButton();
            this.AktifRadio = new System.Windows.Forms.RadioButton();
            this.GorevVeren = new DevExpress.XtraEditors.LookUpEdit();
            this.GorevAlan = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.AciklamaText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GorevVeren.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevAlan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(56, 16);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "Açıklama:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 78);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 16);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Görev Alan:";
            // 
            // Ekle
            // 
            this.Ekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Ekle.ImageOptions.Image")));
            this.Ekle.Location = new System.Drawing.Point(147, 257);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(149, 38);
            this.Ekle.TabIndex = 20;
            this.Ekle.Text = "Ekle";
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 16);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Görev Veren:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 167);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 16);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Tarih:";
            // 
            // AciklamaText
            // 
            this.AciklamaText.Location = new System.Drawing.Point(147, 103);
            this.AciklamaText.Name = "AciklamaText";
            this.AciklamaText.Size = new System.Drawing.Size(149, 55);
            this.AciklamaText.TabIndex = 29;
            // 
            // TarihDate
            // 
            this.TarihDate.EditValue = null;
            this.TarihDate.Location = new System.Drawing.Point(147, 164);
            this.TarihDate.Name = "TarihDate";
            this.TarihDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TarihDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TarihDate.Size = new System.Drawing.Size(149, 22);
            this.TarihDate.TabIndex = 30;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TamamlanmisRadio);
            this.groupControl1.Controls.Add(this.AktifRadio);
            this.groupControl1.Controls.Add(this.GorevVeren);
            this.groupControl1.Controls.Add(this.GorevAlan);
            this.groupControl1.Controls.Add(this.AciklamaText);
            this.groupControl1.Controls.Add(this.TarihDate);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.Ekle);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(341, 312);
            this.groupControl1.TabIndex = 31;
            // 
            // TamamlanmisRadio
            // 
            this.TamamlanmisRadio.AutoSize = true;
            this.TamamlanmisRadio.Location = new System.Drawing.Point(147, 222);
            this.TamamlanmisRadio.Name = "TamamlanmisRadio";
            this.TamamlanmisRadio.Size = new System.Drawing.Size(153, 21);
            this.TamamlanmisRadio.TabIndex = 35;
            this.TamamlanmisRadio.Text = "Tamamlanmış Görev";
            this.TamamlanmisRadio.UseVisualStyleBackColor = true;
            // 
            // AktifRadio
            // 
            this.AktifRadio.AutoSize = true;
            this.AktifRadio.Checked = true;
            this.AktifRadio.Location = new System.Drawing.Point(147, 195);
            this.AktifRadio.Name = "AktifRadio";
            this.AktifRadio.Size = new System.Drawing.Size(96, 21);
            this.AktifRadio.TabIndex = 34;
            this.AktifRadio.TabStop = true;
            this.AktifRadio.Text = "Aktif Görev";
            this.AktifRadio.UseVisualStyleBackColor = true;
            // 
            // GorevVeren
            // 
            this.GorevVeren.Location = new System.Drawing.Point(147, 47);
            this.GorevVeren.Name = "GorevVeren";
            this.GorevVeren.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GorevVeren.Properties.NullText = "";
            this.GorevVeren.Size = new System.Drawing.Size(149, 22);
            this.GorevVeren.TabIndex = 32;
            // 
            // GorevAlan
            // 
            this.GorevAlan.Location = new System.Drawing.Point(147, 75);
            this.GorevAlan.Name = "GorevAlan";
            this.GorevAlan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GorevAlan.Properties.NullText = "";
            this.GorevAlan.Size = new System.Drawing.Size(149, 22);
            this.GorevAlan.TabIndex = 31;
            // 
            // GorevEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 311);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("GorevEkle.IconOptions.Image")));
            this.Name = "GorevEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Ekle";
            this.Load += new System.EventHandler(this.GorevEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AciklamaText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TarihDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GorevVeren.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GorevAlan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton Ekle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit AciklamaText;
        private DevExpress.XtraEditors.DateEdit TarihDate;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit GorevAlan;
        private DevExpress.XtraEditors.LookUpEdit GorevVeren;
        private System.Windows.Forms.RadioButton TamamlanmisRadio;
        private System.Windows.Forms.RadioButton AktifRadio;
    }
}