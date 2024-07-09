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
    public partial class Departmanlar : DevExpress.XtraEditors.XtraForm
    {
        public Departmanlar()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        void Listeleme()
        {

            var degerler = (from x in db.DepartmanlarTablosu
                            select new
                            {
                                x.Departman_ID,
                                x.Departman_Adi
                            }).ToList();
            gridControl1.DataSource = degerler;
            gridView1.Columns[0].Visible = false;
        }
        private void Listele_Click(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            DepartmanlarTablosu t = new DepartmanlarTablosu();
            t.Departman_Adi = AdiText.Text;
            db.DepartmanlarTablosu.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            int id_al = int.Parse(IdText.Text);
            var deger = db.DepartmanlarTablosu.Find(id_al);
            db.DepartmanlarTablosu.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listeleme();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
           
            
            
            IdText.Text = gridView1.GetFocusedRowCellValue("Departman_ID").ToString();
            AdiText.Text = gridView1.GetFocusedRowCellValue("Departman_Adi").ToString();
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            int id_al = int.Parse(IdText.Text);
            var deger = db.DepartmanlarTablosu.Find(id_al);
            deger.Departman_Adi = AdiText.Text;
            db.SaveChanges();
            XtraMessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleştirildi!",
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listeleme();
        }
    }
}
