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
    public partial class AktifCagrilar : DevExpress.XtraEditors.XtraForm
    {
        public AktifCagrilar()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        void AktifCagrilariListele()
        {
            var degerler = from x in db.CagrilarTablosu
                           select new
                           {
                               x.Cagri_ID,
                               x.FirmalarTablosu.Firma_Adi,
                               x.Konu,
                               x.Aciklama,
                               x.Durum,
                               x.Tarih
                           };
            gridControl1.DataSource = degerler.Where(x => x.Durum == true).ToList();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[4].Visible = false;
        }
        private void AktifCagrilar_Load(object sender, EventArgs e)
        {
            AktifCagrilariListele();
        }
        private void Listele_Click(object sender, EventArgs e)
        {
            AktifCagrilariListele();
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            CagriIdText.Text = gridView1.GetFocusedRowCellValue("Cagri_ID").ToString();
            FirmaAdiText.Text = gridView1.GetFocusedRowCellValue("Firma_Adi").ToString();
            KonuText.Text = gridView1.GetFocusedRowCellValue("Konu").ToString();
            AciklamaText.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            TarihDate.EditValue = gridView1.GetFocusedRowCellValue("Tarih").ToString();
        }
        private void Guncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CagriIdText.Text);
            var deger = db.CagrilarTablosu.Find(x);
            deger.Konu = KonuText.Text;
            deger.FirmalarTablosu.Firma_Adi = FirmaAdiText.Text;
            deger.Aciklama = AciklamaText.Text;
            deger.Tarih = Convert.ToDateTime(TarihDate.Text.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AktifCagrilariListele();
        }
        private void Sil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(CagriIdText.Text);
            var deger = db.CagrilarTablosu.Find(x);
            db.CagrilarTablosu.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            AktifCagrilariListele();
        }
        private void CagriyiTamamla_Click(object sender, EventArgs e)
        {
            int x = int.Parse(CagriIdText.Text);
            var deger = db.CagrilarTablosu.Find(x);
            deger.Durum = false;
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AktifCagrilariListele();
        }
    }
}
