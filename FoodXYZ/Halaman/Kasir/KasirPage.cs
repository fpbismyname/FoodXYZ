using FoodXYZ.Halaman.Kasir.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman
{
    public partial class KasirPage : Form
    {
        Automation PH = new Automation();
        public KasirPage()
        {
            InitializeComponent();
        }

        private void Logout(object sender, EventArgs e)
        {
            PH.Navigate(this, new LoginPage.LoginPage());
        }

        private void KasirPage_Onload(object sender, EventArgs e)
        {
            PH.loadForm(KasirPanel, new KelolaTransaksi());
        }
    }
}
