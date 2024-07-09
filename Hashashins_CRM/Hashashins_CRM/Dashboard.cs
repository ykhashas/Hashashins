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

namespace Hashashins_CRM
{
    public partial class Dashboard : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        public string mail;
        Formlar.AnaForm frm9;
        private void Form1_Load(object sender, EventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm9 = new Formlar.AnaForm();
                frm9.MdiParent = this;
                frm9.Show();
            }
}

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
        Formlar.Personelİstatistikleri frm;
        private void Personelİstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm == null || frm.IsDisposed)
            {
                frm = new Formlar.Personelİstatistikleri();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void HesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=hesap+makinesi&sca_esv=596722195&hl=tr&sxsrf=AM9HkKntEN_Xf3h0NjKZec1HIS_VxqjcVg%3A1704760837906&source=hp&ei=BZacZfnNNYDzxc8P8uSG-AQ&iflsig=AO6bgOgAAAAAZZykFUTS13uxrSWvng-0ZRu3XzqEDGam&udm=&oq=hesap+mak&gs_lp=Egdnd3Mtd2l6IgloZXNhcCBtYWsqAggAMgoQIxiABBiKBRgnMgUQABiABDIQEAAYgAQYigUYQxixAxiDATILEAAYgAQYsQMYgwEyBRAAGIAEMgUQABiABDIFEAAYgAQyBRAAGIAEMgUQABiABDIFEAAYgARIlg1QpwNYkAlwAXgAkAEAmAGWAaAB2AmqAQMwLjm4AQPIAQD4AQGoAgrCAgcQIxjqAhgnwgIHEC4Y6gIYJ8ICBBAjGCfCAhEQLhiABBixAxiDARjHARjRA8ICChAAGIAEGIoFGEPCAg4QLhiABBjHARivARiOBcICFBAuGIAEGIoFGLEDGIMBGMcBGNEDwgIFEC4YgATCAhQQLhiABBixAxiDARjHARivARiOBcICCBAAGIAEGLEDwgIQEC4YgAQYigUYQxjHARjRAw&sclient=gws-wiz");
        }
        Formlar.Departmanlar frm2;
        private void DepartmanListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm2 == null || frm2.IsDisposed)
            {
                frm2 = new Formlar.Departmanlar();
                frm2.MdiParent = this;
                frm2.Show();
            }
        }
        Formlar.Personeller frm3;
        private void PersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm3 == null || frm3.IsDisposed)
            {
                frm3 = new Formlar.Personeller();
                frm3.MdiParent = this;
                frm3.Show();
            }
        }

        private void YeniPersonel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.PersonelEkle frm = new Formlar.PersonelEkle();
            frm.Show();
        }

        private void YeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.DepartmanEkle frm3 = new Formlar.DepartmanEkle();
            frm3.Show();
        }
        Formlar.Gorevİstatistikleri frm4;
        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm4 == null || frm4.IsDisposed)
            {
                frm4 = new Formlar.Gorevİstatistikleri();
                frm4.MdiParent = this;
                frm4.Show();
            }
        }
        Formlar.GorevListesi frm5;
        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm5 == null || frm5.IsDisposed)
            {
                frm5 = new Formlar.GorevListesi();
                frm5.MdiParent = this;
                frm5.Show();
            }
        }

        private void YeniGorevTanimla_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.GorevEkle frm = new Formlar.GorevEkle();
            frm.Show();
        }
        Formlar.AktifGorevler frm6;
        private void AktifGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm6 == null || frm6.IsDisposed)
            {
                frm6 = new Formlar.AktifGorevler();
                frm6.MdiParent = this;
                frm6.Show();
            }
        }
        Formlar.TamamlananGorevler frm7;
        private void TamamlananGorevler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm7 == null || frm7.IsDisposed)
            {
                frm7 = new Formlar.TamamlananGorevler();
                frm7.MdiParent = this;
                frm7.Show();
            }
        }
        Formlar.GorevDetaylari frm8;
        private void GorevDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm8 == null || frm8.IsDisposed)
            {
                frm8 = new Formlar.GorevDetaylari();
                frm8.MdiParent = this;
                frm8.Show();
            }
        }

        private void Youtube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void Haberler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://news.google.com/");
        }

        private void Kurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.turkiye.gov.tr/doviz-kurlari");
        }

        private void Haritalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/maps");
        }

        private void Anasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm9 == null || frm9.IsDisposed)
            {
                frm9 = new Formlar.AnaForm();
                frm9.MdiParent = this;
                frm9.Show();
            }

        }
        Formlar.FirmaListesi frm10;
        private void FirmaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm10 == null || frm10.IsDisposed)
            {
                frm10 = new Formlar.FirmaListesi();
                frm10.MdiParent = this;
                frm10.Show();
            }
        }
        
        private void YeniFirmaEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.YeniFirmaEkle frm = new Formlar.YeniFirmaEkle();
            frm.Show();
            
        }
        Formlar.Firmaİstatistikleri frm11;
        private void FirmaIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm11 == null || frm11.IsDisposed)
            {
                frm11 = new Formlar.Firmaİstatistikleri();
                frm11.MdiParent = this;
                frm11.Show();
            }
        }
        Formlar.CagriListesi frm12;
        private void CagriListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm12 == null || frm12.IsDisposed)
            {
                frm12 = new Formlar.CagriListesi();
                frm12.MdiParent = this;
                frm12.Show();
            }
        }

        private void YeniCagriEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.CagriEkle frm = new Formlar.CagriEkle();
            frm.Show();
        }

        Formlar.AktifCagrilar frm13;
        private void AktifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm13 == null || frm13.IsDisposed)
            {
                frm13 = new Formlar.AktifCagrilar();
                frm13.MdiParent = this;
                frm13.Show();
            }
        }
        Formlar.TamamlanmisCagrilar frm14;
        private void PasifCagrilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm14 == null || frm14.IsDisposed)
            {
                frm14 = new Formlar.TamamlanmisCagrilar();
                frm14.MdiParent = this;
                frm14.Show();
            }
        }
        Formlar.Cagriİstatistikleri frm15;
        private void CagriIstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm15 == null || frm15.IsDisposed)
            {
                frm15 = new Formlar.Cagriİstatistikleri();
                frm15.MdiParent = this;
                frm15.Show();
            }
        }
        Formlar.CagriDetaylari frm16;
        private void CagriDetaylari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm16 == null || frm16.IsDisposed)
            {
                frm16 = new Formlar.CagriDetaylari();
                frm16.MdiParent = this;
                frm16.Show();
            }
        }
    }
}
