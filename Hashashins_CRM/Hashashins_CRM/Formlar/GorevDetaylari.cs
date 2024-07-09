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
using System.Data.Entity;

namespace Hashashins_CRM.Formlar
{
    public partial class GorevDetaylari : DevExpress.XtraEditors.XtraForm
    {
        public GorevDetaylari()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void GorevDetaylari_Load(object sender, EventArgs e)
        {
            db.GorevDetaylariTablosu.Load();
            bindingSource1.DataSource = db.GorevDetaylariTablosu.Local;
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
        private void görevDetayınıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
