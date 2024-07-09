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
    public partial class GorevEkle : DevExpress.XtraEditors.XtraForm
    {
        public GorevEkle()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void GorevEkle_Load(object sender, EventArgs e)
        {
            var degerler = (from x in db.PersonelTablosu
                            select new
                            {
                                x.Personel_ID,
                                x.Personel_Adi
                            }
                           ).ToList();
            GorevAlan.Properties.ValueMember = "Personel_ID";
            GorevAlan.Properties.DisplayMember = "Personel_Adi";
            GorevAlan.Properties.DataSource = degerler;
            GorevVeren.Properties.ValueMember = "Personel_ID";
            GorevVeren.Properties.DisplayMember = "Personel_Adi";
            GorevVeren.Properties.DataSource = degerler;
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            GorevlerTablosu t = new GorevlerTablosu();
            t.GorevVeren = int.Parse(GorevVeren.EditValue.ToString());
            t.GorevAlan = int.Parse(GorevAlan.EditValue.ToString());
            t.Aciklama = AciklamaText.Text;
            t.Tarih = Convert.ToDateTime(TarihDate.Text.ToString());
            if (AktifRadio.Checked == true)
            {
                TamamlanmisRadio.Checked = false;
                t.Durum = "1";
            }
            else if (TamamlanmisRadio.Checked == true)
            {
                AktifRadio.Checked = false;
                t.Durum = "0";
            }

            db.GorevlerTablosu.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

       
    }
}
