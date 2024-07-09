namespace Hashashins_CRM
{
    partial class Dashboard
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.YeniGorevTanimla = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.AktifGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.TamamlananGorevler = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.GorevDetaylari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.FirmaListesi = new DevExpress.XtraBars.BarButtonItem();
            this.YeniFirmaEkle = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.FirmaIstatistikleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PersonelListesi = new DevExpress.XtraBars.BarButtonItem();
            this.YeniPersonel = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Personelİstatistikleri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.DepartmanListesi = new DevExpress.XtraBars.BarButtonItem();
            this.YeniDepartman = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Anasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.HesapMakinesi = new DevExpress.XtraBars.BarButtonItem();
            this.Youtube = new DevExpress.XtraBars.BarButtonItem();
            this.Haberler = new DevExpress.XtraBars.BarButtonItem();
            this.Kurlar = new DevExpress.XtraBars.BarButtonItem();
            this.Haritalar = new DevExpress.XtraBars.BarButtonItem();
            this.CagriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.YeniCagriEkle = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.AktifCagrilar = new DevExpress.XtraBars.BarButtonItem();
            this.PasifCagrilar = new DevExpress.XtraBars.BarButtonItem();
            this.CagriIstatistikleri = new DevExpress.XtraBars.BarButtonItem();
            this.CagriDetaylari = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage7 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Görevler";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem11);
            this.ribbonPageGroup8.ItemLinks.Add(this.YeniGorevTanimla);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Görev Listesi";
            this.barButtonItem11.Id = 12;
            this.barButtonItem11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.Image")));
            this.barButtonItem11.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem11.ImageOptions.LargeImage")));
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // YeniGorevTanimla
            // 
            this.YeniGorevTanimla.Caption = "Yeni Görev Tanımla";
            this.YeniGorevTanimla.Id = 13;
            this.YeniGorevTanimla.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("YeniGorevTanimla.ImageOptions.Image")));
            this.YeniGorevTanimla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("YeniGorevTanimla.ImageOptions.LargeImage")));
            this.YeniGorevTanimla.Name = "YeniGorevTanimla";
            this.YeniGorevTanimla.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.YeniGorevTanimla_ItemClick);
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.AktifGorevler);
            this.ribbonPageGroup9.ItemLinks.Add(this.TamamlananGorevler);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // AktifGorevler
            // 
            this.AktifGorevler.Caption = "Aktif Görevler";
            this.AktifGorevler.Id = 14;
            this.AktifGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AktifGorevler.ImageOptions.Image")));
            this.AktifGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AktifGorevler.ImageOptions.LargeImage")));
            this.AktifGorevler.Name = "AktifGorevler";
            this.AktifGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AktifGorevler_ItemClick);
            // 
            // TamamlananGorevler
            // 
            this.TamamlananGorevler.Caption = "Tamamlanan Görevler";
            this.TamamlananGorevler.Id = 15;
            this.TamamlananGorevler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TamamlananGorevler.ImageOptions.Image")));
            this.TamamlananGorevler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("TamamlananGorevler.ImageOptions.LargeImage")));
            this.TamamlananGorevler.Name = "TamamlananGorevler";
            this.TamamlananGorevler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TamamlananGorevler_ItemClick);
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem15);
            this.ribbonPageGroup10.ItemLinks.Add(this.GorevDetaylari);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Görev İstatistikleri";
            this.barButtonItem15.Id = 16;
            this.barButtonItem15.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.Image")));
            this.barButtonItem15.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem15.ImageOptions.LargeImage")));
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // GorevDetaylari
            // 
            this.GorevDetaylari.Caption = "Görev Detayları";
            this.GorevDetaylari.Id = 18;
            this.GorevDetaylari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GorevDetaylari.ImageOptions.Image")));
            this.GorevDetaylari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GorevDetaylari.ImageOptions.LargeImage")));
            this.GorevDetaylari.Name = "GorevDetaylari";
            this.GorevDetaylari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GorevDetaylari_ItemClick);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Firmalar";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.FirmaListesi);
            this.ribbonPageGroup6.ItemLinks.Add(this.YeniFirmaEkle);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // FirmaListesi
            // 
            this.FirmaListesi.Caption = "Firma Listesi";
            this.FirmaListesi.Id = 9;
            this.FirmaListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("FirmaListesi.ImageOptions.Image")));
            this.FirmaListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FirmaListesi.ImageOptions.LargeImage")));
            this.FirmaListesi.Name = "FirmaListesi";
            this.FirmaListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FirmaListesi_ItemClick);
            // 
            // YeniFirmaEkle
            // 
            this.YeniFirmaEkle.Caption = "Yeni Firma Ekle";
            this.YeniFirmaEkle.Id = 10;
            this.YeniFirmaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("YeniFirmaEkle.ImageOptions.Image")));
            this.YeniFirmaEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("YeniFirmaEkle.ImageOptions.LargeImage")));
            this.YeniFirmaEkle.Name = "YeniFirmaEkle";
            this.YeniFirmaEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.YeniFirmaEkle_ItemClick);
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.FirmaIstatistikleri);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // FirmaIstatistikleri
            // 
            this.FirmaIstatistikleri.Caption = "Firma İstatistikleri";
            this.FirmaIstatistikleri.Id = 11;
            this.FirmaIstatistikleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FirmaIstatistikleri.ImageOptions.SvgImage")));
            this.FirmaIstatistikleri.Name = "FirmaIstatistikleri";
            this.FirmaIstatistikleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FirmaIstatistikleri_ItemClick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Personeller";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.PersonelListesi);
            this.ribbonPageGroup4.ItemLinks.Add(this.YeniPersonel);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // PersonelListesi
            // 
            this.PersonelListesi.Caption = "Personel Listesi";
            this.PersonelListesi.Id = 6;
            this.PersonelListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PersonelListesi.ImageOptions.Image")));
            this.PersonelListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PersonelListesi.ImageOptions.LargeImage")));
            this.PersonelListesi.Name = "PersonelListesi";
            this.PersonelListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PersonelListesi_ItemClick);
            // 
            // YeniPersonel
            // 
            this.YeniPersonel.Caption = "Yeni Personel Ekle";
            this.YeniPersonel.Id = 7;
            this.YeniPersonel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("YeniPersonel.ImageOptions.Image")));
            this.YeniPersonel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("YeniPersonel.ImageOptions.LargeImage")));
            this.YeniPersonel.Name = "YeniPersonel";
            this.YeniPersonel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.YeniPersonel_ItemClick);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.Personelİstatistikleri);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // Personelİstatistikleri
            // 
            this.Personelİstatistikleri.Caption = "Personel İstatistikleri";
            this.Personelİstatistikleri.Id = 8;
            this.Personelİstatistikleri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Personelİstatistikleri.ImageOptions.SvgImage")));
            this.Personelİstatistikleri.Name = "Personelİstatistikleri";
            this.Personelİstatistikleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Personelİstatistikleri_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Departmanlar";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.DepartmanListesi);
            this.ribbonPageGroup2.ItemLinks.Add(this.YeniDepartman);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // DepartmanListesi
            // 
            this.DepartmanListesi.Caption = "Departman Listesi";
            this.DepartmanListesi.Id = 2;
            this.DepartmanListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("DepartmanListesi.ImageOptions.Image")));
            this.DepartmanListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("DepartmanListesi.ImageOptions.LargeImage")));
            this.DepartmanListesi.Name = "DepartmanListesi";
            this.DepartmanListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DepartmanListesi_ItemClick);
            // 
            // YeniDepartman
            // 
            this.YeniDepartman.Caption = "Yeni Departman";
            this.YeniDepartman.Id = 3;
            this.YeniDepartman.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("YeniDepartman.ImageOptions.Image")));
            this.YeniDepartman.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("YeniDepartman.ImageOptions.LargeImage")));
            this.YeniDepartman.Name = "YeniDepartman";
            this.YeniDepartman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.YeniDepartman_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Departman Detayları";
            this.barButtonItem4.Id = 4;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Rapor Getir";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "AnaSayfa";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.Anasayfa);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // Anasayfa
            // 
            this.Anasayfa.Caption = "Ana Sayfa";
            this.Anasayfa.Id = 1;
            this.Anasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Anasayfa.ImageOptions.Image")));
            this.Anasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Anasayfa.ImageOptions.LargeImage")));
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Anasayfa_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Görev Detayları";
            this.barButtonItem16.Id = 17;
            this.barButtonItem16.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.ImageOptions.Image")));
            this.barButtonItem16.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem16.ImageOptions.LargeImage")));
            this.barButtonItem16.Name = "barButtonItem16";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ribbonControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.Anasayfa,
            this.DepartmanListesi,
            this.YeniDepartman,
            this.barButtonItem4,
            this.barButtonItem5,
            this.PersonelListesi,
            this.YeniPersonel,
            this.Personelİstatistikleri,
            this.FirmaListesi,
            this.YeniFirmaEkle,
            this.FirmaIstatistikleri,
            this.barButtonItem11,
            this.YeniGorevTanimla,
            this.AktifGorevler,
            this.TamamlananGorevler,
            this.barButtonItem15,
            this.GorevDetaylari,
            this.HesapMakinesi,
            this.Youtube,
            this.Haberler,
            this.Kurlar,
            this.Haritalar,
            this.CagriListesi,
            this.YeniCagriEkle,
            this.barButtonItem3,
            this.AktifCagrilar,
            this.PasifCagrilar,
            this.CagriIstatistikleri,
            this.CagriDetaylari});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 31;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 289;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage7,
            this.ribbonPage6});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl1.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(998, 193);
            // 
            // HesapMakinesi
            // 
            this.HesapMakinesi.Caption = "Hesap Makinesi";
            this.HesapMakinesi.Id = 19;
            this.HesapMakinesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HesapMakinesi.ImageOptions.Image")));
            this.HesapMakinesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HesapMakinesi.ImageOptions.LargeImage")));
            this.HesapMakinesi.Name = "HesapMakinesi";
            this.HesapMakinesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HesapMakinesi_ItemClick);
            // 
            // Youtube
            // 
            this.Youtube.Caption = "Youtube";
            this.Youtube.Id = 20;
            this.Youtube.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Youtube.ImageOptions.Image")));
            this.Youtube.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Youtube.ImageOptions.LargeImage")));
            this.Youtube.Name = "Youtube";
            this.Youtube.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Youtube_ItemClick);
            // 
            // Haberler
            // 
            this.Haberler.Caption = "Haberler";
            this.Haberler.Id = 21;
            this.Haberler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Haberler.ImageOptions.Image")));
            this.Haberler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Haberler.ImageOptions.LargeImage")));
            this.Haberler.Name = "Haberler";
            this.Haberler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Haberler_ItemClick);
            // 
            // Kurlar
            // 
            this.Kurlar.Caption = "Kurlar";
            this.Kurlar.Id = 22;
            this.Kurlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Kurlar.ImageOptions.Image")));
            this.Kurlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Kurlar.ImageOptions.LargeImage")));
            this.Kurlar.Name = "Kurlar";
            this.Kurlar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Kurlar_ItemClick);
            // 
            // Haritalar
            // 
            this.Haritalar.Caption = "Haritalar";
            this.Haritalar.Id = 23;
            this.Haritalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Haritalar.ImageOptions.Image")));
            this.Haritalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Haritalar.ImageOptions.LargeImage")));
            this.Haritalar.Name = "Haritalar";
            this.Haritalar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Haritalar_ItemClick);
            // 
            // CagriListesi
            // 
            this.CagriListesi.Caption = "Çağrı Listesi";
            this.CagriListesi.Id = 24;
            this.CagriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CagriListesi.ImageOptions.Image")));
            this.CagriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CagriListesi.ImageOptions.LargeImage")));
            this.CagriListesi.Name = "CagriListesi";
            this.CagriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CagriListesi_ItemClick);
            // 
            // YeniCagriEkle
            // 
            this.YeniCagriEkle.Caption = "Yeni Çağrı Tanımla";
            this.YeniCagriEkle.Id = 25;
            this.YeniCagriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("YeniCagriEkle.ImageOptions.Image")));
            this.YeniCagriEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("YeniCagriEkle.ImageOptions.LargeImage")));
            this.YeniCagriEkle.Name = "YeniCagriEkle";
            this.YeniCagriEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.YeniCagriEkle_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 26;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // AktifCagrilar
            // 
            this.AktifCagrilar.Caption = "Aktif Çağrılar";
            this.AktifCagrilar.Id = 27;
            this.AktifCagrilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AktifCagrilar.ImageOptions.Image")));
            this.AktifCagrilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("AktifCagrilar.ImageOptions.LargeImage")));
            this.AktifCagrilar.Name = "AktifCagrilar";
            this.AktifCagrilar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AktifCagrilar_ItemClick);
            // 
            // PasifCagrilar
            // 
            this.PasifCagrilar.Caption = "Tamamlanmış Çağrılar";
            this.PasifCagrilar.Id = 28;
            this.PasifCagrilar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PasifCagrilar.ImageOptions.Image")));
            this.PasifCagrilar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("PasifCagrilar.ImageOptions.LargeImage")));
            this.PasifCagrilar.Name = "PasifCagrilar";
            this.PasifCagrilar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.PasifCagrilar_ItemClick);
            // 
            // CagriIstatistikleri
            // 
            this.CagriIstatistikleri.Caption = "Çağrı İstatistikleri";
            this.CagriIstatistikleri.Id = 29;
            this.CagriIstatistikleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("CagriIstatistikleri.ImageOptions.Image")));
            this.CagriIstatistikleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("CagriIstatistikleri.ImageOptions.LargeImage")));
            this.CagriIstatistikleri.Name = "CagriIstatistikleri";
            this.CagriIstatistikleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CagriIstatistikleri_ItemClick);
            // 
            // CagriDetaylari
            // 
            this.CagriDetaylari.Caption = "Çağrı Detayları";
            this.CagriDetaylari.Id = 30;
            this.CagriDetaylari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.CagriDetaylari.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.CagriDetaylari.Name = "CagriDetaylari";
            this.CagriDetaylari.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CagriDetaylari_ItemClick);
            // 
            // ribbonPage7
            // 
            this.ribbonPage7.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.ribbonPage7.Name = "ribbonPage7";
            this.ribbonPage7.Text = "Çağrılar";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.CagriListesi);
            this.ribbonPageGroup3.ItemLinks.Add(this.YeniCagriEkle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.AktifCagrilar);
            this.ribbonPageGroup12.ItemLinks.Add(this.PasifCagrilar);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.CagriIstatistikleri);
            this.ribbonPageGroup13.ItemLinks.Add(this.CagriDetaylari);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup11});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Araçlar";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.HesapMakinesi);
            this.ribbonPageGroup11.ItemLinks.Add(this.Youtube);
            this.ribbonPageGroup11.ItemLinks.Add(this.Haberler);
            this.ribbonPageGroup11.ItemLinks.Add(this.Kurlar);
            this.ribbonPageGroup11.ItemLinks.Add(this.Haritalar);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Dashboard
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 556);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.IconOptions.Image")));
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Ribbon = this.ribbonControl1;
            this.RibbonVisibility = DevExpress.XtraBars.Ribbon.RibbonVisibility.Visible;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASHASHINS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem Anasayfa;
        private DevExpress.XtraBars.BarButtonItem DepartmanListesi;
        private DevExpress.XtraBars.BarButtonItem YeniDepartman;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem PersonelListesi;
        private DevExpress.XtraBars.BarButtonItem YeniPersonel;
        private DevExpress.XtraBars.BarButtonItem Personelİstatistikleri;
        private DevExpress.XtraBars.BarButtonItem FirmaListesi;
        private DevExpress.XtraBars.BarButtonItem YeniFirmaEkle;
        private DevExpress.XtraBars.BarButtonItem FirmaIstatistikleri;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem YeniGorevTanimla;
        private DevExpress.XtraBars.BarButtonItem AktifGorevler;
        private DevExpress.XtraBars.BarButtonItem TamamlananGorevler;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
        private DevExpress.XtraBars.BarButtonItem GorevDetaylari;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.BarButtonItem HesapMakinesi;
        private DevExpress.XtraBars.BarButtonItem Youtube;
        private DevExpress.XtraBars.BarButtonItem Haberler;
        private DevExpress.XtraBars.BarButtonItem Kurlar;
        private DevExpress.XtraBars.BarButtonItem Haritalar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem CagriListesi;
        private DevExpress.XtraBars.BarButtonItem YeniCagriEkle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem AktifCagrilar;
        private DevExpress.XtraBars.BarButtonItem PasifCagrilar;
        private DevExpress.XtraBars.BarButtonItem CagriIstatistikleri;
        private DevExpress.XtraBars.BarButtonItem CagriDetaylari;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
    }
}

