using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hashashins_CRM.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Hashashins_CRM.Formlar
{
    public partial class PersonelEkle : DevExpress.XtraEditors.XtraForm
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void Ekle_Click(object sender, EventArgs e)
        {
            PersonelTablosu t = new PersonelTablosu();
            t.Personel_Adi = AdiText.Text;
            t.Personel_Soyadi = SoyadiText.Text;
            t.Mail_Adresi = MailText.Text;
            t.Telefon_No = TelNoText.Text;
            t.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            t.Durum = DurumCheck.Checked;
            db.PersonelTablosu.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            var departmanlar = (from x in db.DepartmanlarTablosu
                                select new
                                {
                                    x.Departman_ID,
                                    x.Departman_Adi
                                }).ToList();
            lookUpEdit1.Properties.ValueMember = "Departman_ID";
            lookUpEdit1.Properties.DisplayMember = "Departman_Adi";
            lookUpEdit1.Properties.DataSource = departmanlar;
        }
    }
}
