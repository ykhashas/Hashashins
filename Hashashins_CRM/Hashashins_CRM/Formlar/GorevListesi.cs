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
    public partial class GorevListesi : DevExpress.XtraEditors.XtraForm
    {
        public GorevListesi()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        void GorevListeleme()
        {
            var degerler = from x in db.GorevlerTablosu
                           select new
                           {
                               x.Gorev_ID,
                               x.GorevAlan,
                               x.GorevVeren,
                               x.Aciklama,
                               x.Durum,
                               x.Tarih
                           };
            gridControl1.DataSource = degerler.ToList();
            gridView1.Columns[0].Visible = false;
            gridView1.Columns[4].Visible = false;
        }

        private void GorevListesi_Load(object sender, EventArgs e)
        {
            GorevListeleme();
        }

        private void Listele_Click(object sender, EventArgs e)
        {
            GorevListeleme();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(GorevIdText.Text);
            var deger = db.GorevlerTablosu.Find(x);
            db.GorevlerTablosu.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            GorevListeleme();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GorevIdText.Text = gridView1.GetFocusedRowCellValue("Gorev_ID").ToString();
            GorevVerenText.Text = gridView1.GetFocusedRowCellValue("GorevVeren").ToString();
            GorevAlanText.Text = gridView1.GetFocusedRowCellValue("GorevAlan").ToString();
            AciklamaText.Text = gridView1.GetFocusedRowCellValue("Aciklama").ToString();
            TarihDate.EditValue = gridView1.GetFocusedRowCellValue("Tarih").ToString();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            
            int x = int.Parse(GorevIdText.Text);
            var deger = db.GorevlerTablosu.Find(x);
            deger.GorevVeren = int.Parse(GorevVerenText.Text);
            deger.GorevAlan = int.Parse(GorevAlanText.Text);
            deger.Aciklama = AciklamaText.Text;
            deger.Tarih = Convert.ToDateTime(TarihDate.Text.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GorevListeleme();
        }

        private void AktifeAl_Click(object sender, EventArgs e)
        {
            int x = int.Parse(GorevIdText.Text);
            var deger = db.GorevlerTablosu.Find(x);
            deger.Durum = "1";
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GorevListeleme();
        }

        private void Tamamla_Click(object sender, EventArgs e)
        {
            int x = int.Parse(GorevIdText.Text);
            var deger = db.GorevlerTablosu.Find(x);
            deger.Durum = "0";
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GorevListeleme();
        }
    }
}
