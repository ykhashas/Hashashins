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
    public partial class CagriDetaylari : DevExpress.XtraEditors.XtraForm
    {
        public CagriDetaylari()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void CagriDetaylari_Load(object sender, EventArgs e)
        {
            db.CagriDetaylariTablosu.Load();
            bindingSource1.DataSource = db.CagriDetaylariTablosu.Local;
        }
        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }
        private void çağrıDetayınıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
