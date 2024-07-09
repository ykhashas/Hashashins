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
    public partial class Firmaİstatistikleri : DevExpress.XtraEditors.XtraForm
    {
        public Firmaİstatistikleri()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();

        private void ToplamFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            if (ToplamFirmalar.Checked == true)
            {
                int toplamfirmalar = int.Parse(db.FirmalarTablosu.Count().ToString());
                chartControl1.Series["Firma İstatistikleri"].Points.AddPoint("Toplam Firmalar", toplamfirmalar);
                ToplamFirmalar.Enabled = false;
            }
        }

        private void Temizle2_Click(object sender, EventArgs e)
        {
            ToplamFirmalar.Checked = false;
            IlSayisi.Checked = false;
            chartControl1.Series["Firma İstatistikleri"].Points.Clear();
            ToplamFirmalar.Enabled = true;
            IlSayisi.Enabled = true;
        }

        private void IlSayisi_CheckedChanged(object sender, EventArgs e)
        {
            int ilsayisi = int.Parse(db.FirmalarTablosu.Select(x => x.Firma_İl).Distinct().Count().ToString());
            if (IlSayisi.Checked == true)

                chartControl1.Series["Firma İstatistikleri"].Points.AddPoint("İş Yapılan İl Sayısı", ilsayisi);
            IlSayisi.Enabled = false;
        }

        private void Istanbul_CheckedChanged(object sender, EventArgs e)
        {
            if (Istanbul.Checked == true)
            {
                int istanbul = int.Parse(db.FirmalarTablosu.Where(x => x.Firma_İl == "İstanbul").Distinct().Count().ToString());
                chartControl2.Series["İller"].Points.AddPoint("İstanbul", istanbul);
                Istanbul.Enabled = false;
            }
        }

        private void İzmir_CheckedChanged(object sender, EventArgs e)
        {
            if (İzmir.Checked == true)
            {
                int izmir = int.Parse(db.FirmalarTablosu.Where(x => x.Firma_İl == "İzmir").Distinct().Count().ToString());
                chartControl2.Series["İller"].Points.AddPoint("İzmir", izmir);
                İzmir.Enabled = false;
            }
        }

        private void Bursa_CheckedChanged(object sender, EventArgs e)
        {
            if (Bursa.Checked == true)
            {
                int bursa = int.Parse(db.FirmalarTablosu.Where(x => x.Firma_İl == "Bursa").Distinct().Count().ToString());
                chartControl2.Series["İller"].Points.AddPoint("Bursa", bursa);
                Bursa.Enabled = false;
            }
        }

        private void Ankara_CheckedChanged(object sender, EventArgs e)
        {
            if (Ankara.Checked == true)
            {
                int ankara = int.Parse(db.FirmalarTablosu.Where(x => x.Firma_İl == "Ankara").Distinct().Count().ToString());
                chartControl2.Series["İller"].Points.AddPoint("Ankara", ankara);
                Ankara.Enabled = false;
            }
        }

        private void Temizle1_Click(object sender, EventArgs e)
        {
            Istanbul.Checked = false;
            Ankara.Checked = false;
            İzmir.Checked = false;
            Bursa.Checked = false;
            chartControl2.Series["İller"].Points.Clear();
            Istanbul.Enabled = true;
            Ankara.Enabled = true;
            İzmir.Enabled = true;
            Bursa.Enabled = true;
        }
    }
}
