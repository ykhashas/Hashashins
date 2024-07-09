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
    public partial class Personeller : DevExpress.XtraEditors.XtraForm
    {
        public Personeller()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        void PersonelListele()
        {
            var degerler = from x in db.PersonelTablosu
                           select new
                           {
                               x.Personel_ID,
                               x.Personel_Adi,
                               x.Personel_Soyadi,
                               x.Mail_Adresi,
                               x.DepartmanlarTablosu.Departman_Adi,
                               x.Durum
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
            gridView1.Columns[0].Visible = false;
        }
        private void Personeller_Load(object sender, EventArgs e)
        {
            PersonelListele();
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

        private void Listele_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(IdText.Text);
            var deger = db.PersonelTablosu.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            PersonelListele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IdText.Text = gridView1.GetFocusedRowCellValue("Personel_ID").ToString();
            AdiText.Text = gridView1.GetFocusedRowCellValue("Personel_Adi").ToString();
            SoyadiText.Text = gridView1.GetFocusedRowCellValue("Personel_Soyadi").ToString();
            MailText.Text = gridView1.GetFocusedRowCellValue("Mail_Adresi").ToString();
            lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("Personel_ID").ToString();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(IdText.Text);
            var deger = db.PersonelTablosu.Find(x);
            deger.Personel_Adi = AdiText.Text;
            deger.Personel_Soyadi = SoyadiText.Text;
            deger.Mail_Adresi = MailText.Text;
            deger.Departman = int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
        }
    }
}
