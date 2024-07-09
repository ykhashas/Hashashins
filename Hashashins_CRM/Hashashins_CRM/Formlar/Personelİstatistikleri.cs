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

namespace Hashashins_CRM.Formlar
{
    public partial class Personelİstatistikleri : DevExpress.XtraEditors.XtraForm
    {
        public Personelİstatistikleri()
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
            gridControl1.DataSource = degerler.ToList();

        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            AktifPersonel.Checked = false;
            PasifPersonel.Checked = false;
            chartControl1.Series["Personel İstatistikleri"].Points.Clear();
            ToplamPersonel.Enabled = true;
            AktifPersonel.Enabled = true;
            PasifPersonel.Enabled = true;
            ToplamPersonel.Checked = false;
        }

        private void ToplamPersonel_CheckedChanged(object sender, EventArgs e)
        {
            if (ToplamPersonel.Checked == true)
            {
                int toplampersonel = int.Parse(db.PersonelTablosu.Count().ToString());
                chartControl1.Series["Personel İstatistikleri"].Points.AddPoint("Toplam Personel", toplampersonel);
                ToplamPersonel.Enabled = false;
            }
        }

        private void PersonelAdi_EditValueChanged(object sender, EventArgs e)
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
            gridControl1.DataSource = degerler.Where(x => x.Personel_Adi == PersonelAdi.Text).ToList();
            db.SaveChanges();
            if (PersonelAdi.Text == "")
            {
                PersonelListele();

            }
        }

        private void PersonelAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Formdeneme_Load(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void PasifPersonel_CheckedChanged(object sender, EventArgs e)
        {
            int pasifpersonel = int.Parse(db.PersonelTablosu.Where(x => x.Durum == false).Count().ToString());
            if (PasifPersonel.Checked == true)

                chartControl1.Series["Personel İstatistikleri"].Points.AddPoint("A. Olmayan Personel", pasifpersonel);
            PasifPersonel.Enabled = false;
        }

        private void AktifPersonel_CheckedChanged(object sender, EventArgs e)
        {
            int aktifpersonel = int.Parse(db.PersonelTablosu.Where(x => x.Durum == true).Count().ToString());
            if (AktifPersonel.Checked == true)

                chartControl1.Series["Personel İstatistikleri"].Points.AddPoint("Aktif Personel", aktifpersonel);
            AktifPersonel.Enabled = false;
        }
    }
}
