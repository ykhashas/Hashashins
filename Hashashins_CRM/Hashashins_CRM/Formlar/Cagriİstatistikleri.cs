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
    public partial class Cagriİstatistikleri : DevExpress.XtraEditors.XtraForm
    {
        public Cagriİstatistikleri()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        private void ToplamCagri_CheckedChanged(object sender, EventArgs e)
        {
            if (ToplamCagri.Checked == true)
            {
                int toplamcagri = int.Parse(db.CagrilarTablosu.Count().ToString());
                chartControl1.Series["Çağrı İstatistikleri"].Points.AddPoint("Tüm Çağrılar", toplamcagri);
                ToplamCagri.Enabled = false;
            }
        }
        private void Temizle_Click(object sender, EventArgs e)
        {
            AktifCagri.Checked = false;
            TamamlananCagri.Checked = false;
            chartControl1.Series["Çağrı İstatistikleri"].Points.Clear();
            ToplamCagri.Enabled = true;
            AktifCagri.Enabled = true;
            TamamlananCagri.Enabled = true;
            ToplamCagri.Checked = false;
        }
        private void TamamlananCagri_CheckedChanged(object sender, EventArgs e)
        {
            int tamamlanancagrilar = int.Parse(db.CagrilarTablosu.Where(x => x.Durum == false).Count().ToString());
            if (TamamlananCagri.Checked == true)

                chartControl1.Series["Çağrı İstatistikleri"].Points.AddPoint("Tamamlanan Çağrılar", tamamlanancagrilar);
            TamamlananCagri.Enabled = false;
        }
        private void AktifCagri_CheckedChanged(object sender, EventArgs e)
        {
            int aktifcagrilar = int.Parse(db.CagrilarTablosu.Where(x => x.Durum == true).Count().ToString());
            if (AktifCagri.Checked == true)

                chartControl1.Series["Çağrı İstatistikleri"].Points.AddPoint("Aktif Çağrılar", aktifcagrilar);
            AktifCagri.Enabled = false;
        }
    }
}
