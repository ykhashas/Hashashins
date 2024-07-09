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
    public partial class CagriEkle : DevExpress.XtraEditors.XtraForm
    {
        public CagriEkle()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void Ekle_Click(object sender, EventArgs e)
        {
            CagrilarTablosu t = new CagrilarTablosu();
            t.Konu = KonuText.Text;
            t.Cagri_Firmasi = int.Parse(CagriFirmasi.EditValue.ToString());
            t.Aciklama = AciklamaText.Text;
            t.Tarih = Convert.ToDateTime(TarihDate.Text.ToString());
            if (AktifRadio.Checked == true)
            {
                TamamlanmisRadio.Checked = false;
                t.Durum = true;
            }
            else if (TamamlanmisRadio.Checked == true)
            {
                AktifRadio.Checked = false;
                t.Durum = false;
            }
            db.CagrilarTablosu.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void CagriEkle_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.FirmalarTablosu
                            select new
                            {
                                x.Firma_ID,
                                x.Firma_Adi
                            }
                           ).ToList();
            CagriFirmasi.Properties.ValueMember = "Firma_ID";
            CagriFirmasi.Properties.DisplayMember = "Firma_Adi";
            CagriFirmasi.Properties.DataSource = degerler;
        }
    }
}

