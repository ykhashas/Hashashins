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
    public partial class YeniFirmaEkle : DevExpress.XtraEditors.XtraForm
    {
        public YeniFirmaEkle()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void Ekle_Click(object sender, EventArgs e)
        {
            FirmalarTablosu t = new FirmalarTablosu();
            t.Firma_Adi = FirmaAdiText.Text;
            t.Yetkili_Adi = YetkiliAdiText.Text;
            t.Telefon_No = TelefonNoText.Text;
            t.Mail_Adresi = MailText.Text;
            t.Firma_İl = FirmailText.Text;
            t.Firma_İlce = FirmailceText.Text;
            t.Firma_Adresi = FirmaAdresText.Text;
            db.FirmalarTablosu.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void YeniFirmaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
