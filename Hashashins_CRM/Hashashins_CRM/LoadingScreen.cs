using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hashashins_CRM
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 2;
            this.Opacity += 0.025;

            if(panel2.Width>=511)
            {
                timer1.Stop();
                Giriş_Formu.LoginFormu frm1 = new Giriş_Formu.LoginFormu();
                frm1.Show();
                this.Hide();
                

            }

        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
    }
}
