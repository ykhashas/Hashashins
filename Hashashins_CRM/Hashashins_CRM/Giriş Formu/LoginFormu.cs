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

namespace Hashashins_CRM.Giriş_Formu
{
    public partial class LoginFormu : DevExpress.XtraEditors.XtraForm
    {
        public LoginFormu()
        {
            InitializeComponent();
        }
        HashashinsDbEntities db = new HashashinsDbEntities();
        private void hyperlinkLabelControl2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textEdit1_Click(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
        }

        private void textEdit2_Click(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
        }

        private void LoginFormu_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            var admingiris = db.PersonelTablosu.Where(x => x.Mail_Adresi == 
            KullaniciText.Text && x.Sifre == SifreText.Text).FirstOrDefault();

            if (admingiris!=null)
            {
                XtraMessageBox.Show("Başarıyla Giriş Yaptınız!");
                Dashboard fr = new Dashboard();
                fr.Show();
                this.Hide();

            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş Yaptınız!");
            }
        }
    }
}
