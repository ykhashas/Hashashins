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
    public partial class AnaForm : DevExpress.XtraEditors.XtraForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void AnaForm_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.GorevlerTablosu
                                       select new
                                       {
                                           x.Aciklama,
                                           Adi_Soyadi=x.PersonelTablosu.Personel_Adi +" "+ x.PersonelTablosu.Personel_Soyadi,
                                           x.Durum
                                       }).Where(y=>y.Durum=="1").ToList();
            gridView1.Columns["Durum"].Visible = false;
            DateTime bugun = DateTime.Parse(DateTime.Now.ToShortDateString());
            
            gridControl2.DataSource = (from x in db.GorevDetaylariTablosu
                                       select new
                                       {
                                           Gorev = x.GorevlerTablosu.Aciklama,
                                           x.Aciklama,
                                           x.Tarih
                                       }).Where(x => x.Tarih == bugun).ToList();
            gridControl3.DataSource = (from x in db.CagrilarTablosu
                                       select new
                                       {
                                           x.FirmalarTablosu.Firma_Adi,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == true).ToList();
            gridView3.Columns["Durum"].Visible = false;

            gridControl4.DataSource = (from x in db.CagrilarTablosu
                                       select new
                                       {
                                           x.FirmalarTablosu.Firma_Adi,
                                           x.Konu,
                                           x.Tarih,
                                           x.Durum
                                       }).Where(x => x.Durum == false).ToList();
            gridView4.Columns["Durum"].Visible = false;


            int devamedengorevler = int.Parse(db.GorevlerTablosu.Where(x => x.Durum == "1").Count().ToString());
            chartControl1.Series["Günlük Veriler"].Points.AddPoint("Aktif Görevler", devamedengorevler);
            int bugunungorevleri = int.Parse(db.GorevlerTablosu.Where(x => x.Tarih == bugun).Count().ToString());
            chartControl1.Series["Günlük Veriler"].Points.AddPoint("Bugünün Görevleri", bugunungorevleri);
            int aktifcagrilar = int.Parse(db.CagrilarTablosu.Where(x => x.Durum == true).Count().ToString());
            chartControl1.Series["Günlük Veriler"].Points.AddPoint("Aktif Çağrılar", aktifcagrilar);
            int pasifcagrilar = int.Parse(db.CagrilarTablosu.Where(x => x.Durum == false).Count().ToString());
            chartControl1.Series["Günlük Veriler"].Points.AddPoint("T. Çağrılar", pasifcagrilar);

            db.SaveChanges();
        }
    }
}
