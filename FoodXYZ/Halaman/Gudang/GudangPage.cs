using FoodXYZ.Halaman.Gudang.Page;
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
    public partial class GudangPage : Form
    {
        Automation PH = new Automation();
        public GudangPage()
        {
            InitializeComponent();
        }

        private void LogOut(object sender, EventArgs e)
        {
            PH.Navigate(this, new LoginPage.LoginPage());
        }

        private void GudangPage_Load(object sender, EventArgs e)
        {
            PH.loadForm(GudangPanel, new KelolaBarang());
        }
    }
}
