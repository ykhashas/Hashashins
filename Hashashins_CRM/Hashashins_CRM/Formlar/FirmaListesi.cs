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
    public partial class FirmaListesi : DevExpress.XtraEditors.XtraForm
    {
        public FirmaListesi()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        void FirmaListeleme()
        {
            var degerler = from x in db.FirmalarTablosu
                           select new
                           {
                               x.Firma_ID,
                               x.Firma_Adi,
                               x.Yetkili_Adi,
                               x.Telefon_No,
                               x.Mail_Adresi,
                               x.Firma_İl,
                               x.Firma_İlce,
                               x.Firma_Adresi
                           };
            gridControl1.DataSource = degerler.ToList();
            gridView1.Columns[0].Visible = false;
        }

        private void FirmaListesi_Load(object sender, EventArgs e)
        {
            FirmaListeleme();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            FirmaListeleme();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(FirmaIdText.Text);
            var deger = db.GorevlerTablosu.Find(x);
            db.GorevlerTablosu.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            FirmaListeleme();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            FirmaIdText.Text = gridView1.GetFocusedRowCellValue("Firma_ID").ToString();
            FirmaAdiText.Text = gridView1.GetFocusedRowCellValue("Firma_Adi").ToString();
            YetkiliAdiText.Text = gridView1.GetFocusedRowCellValue("Yetkili_Adi").ToString();
            TelefonNoText.Text = gridView1.GetFocusedRowCellValue("Telefon_No").ToString();
            MailText.Text = gridView1.GetFocusedRowCellValue("Mail_Adresi").ToString();
            FirmailText.EditValue = gridView1.GetFocusedRowCellValue("Firma_İl").ToString();
            FirmailceText.EditValue = gridView1.GetFocusedRowCellValue("Firma_İlce").ToString();
            FirmaAdresText.EditValue = gridView1.GetFocusedRowCellValue("Firma_Adresi").ToString();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(FirmaIdText.Text);
            var deger = db.FirmalarTablosu.Find(x);
            deger.Firma_Adi = FirmaAdiText.Text;
            deger.Yetkili_Adi = YetkiliAdiText.Text;
            deger.Telefon_No = TelefonNoText.Text;
            deger.Mail_Adresi = MailText.Text;
            deger.Firma_İl = FirmailText.Text;
            deger.Firma_İlce = FirmailceText.Text;
            deger.Firma_Adresi = FirmaAdresText.Text;
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FirmaListeleme();
        }
    }
}
