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
    public partial class Gorevİstatistikleri : DevExpress.XtraEditors.XtraForm
    {
        public Gorevİstatistikleri()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void ToplamGorevler_CheckedChanged(object sender, EventArgs e)
        {
            if (ToplamGorevler.Checked == true)
            {
                int toplamgorevler = int.Parse(db.GorevlerTablosu.Count().ToString());
                chartControl1.Series["Görev İstatistikleri"].Points.AddPoint("Toplam Görevler", toplamgorevler);
                ToplamGorevler.Enabled = false;
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            AktifGorevler.Checked = false;
            TamamlananGorevler.Checked = false;
            chartControl1.Series["Görev İstatistikleri"].Points.Clear();
            ToplamGorevler.Enabled = true;
            AktifGorevler.Enabled = true;
            TamamlananGorevler.Enabled = true;
            ToplamGorevler.Checked = false;
        }
        private void TamamlananGorevler_CheckedChanged(object sender, EventArgs e)
        {
            int tamamlanangorevler = int.Parse(db.GorevlerTablosu.Where(x => x.Durum=="0").Count().ToString());
            if (TamamlananGorevler.Checked == true)

                chartControl1.Series["Görev İstatistikleri"].Points.AddPoint("Tamamlanan Görevler", tamamlanangorevler);
            TamamlananGorevler.Enabled = false;
        }
        private void AktifGorevler_CheckedChanged(object sender, EventArgs e)
        {
            int aktifgorevler = int.Parse(db.GorevlerTablosu.Where(x => x.Durum == "1").Count().ToString());
            if (AktifGorevler.Checked == true)

                chartControl1.Series["Görev İstatistikleri"].Points.AddPoint("Aktif Görevler", aktifgorevler);
            AktifGorevler.Enabled = false;
        }
    }
}
