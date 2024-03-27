using FoodXYZ.Halaman.Admin.Page;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman.AdminPage
{
    public partial class AdminPage : Form
    {
        Automation PH = new Automation();
        public AdminPage()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            PH.loadForm(MainPanel, new LogPage());
        }

        private void Logout(object sender, EventArgs e)
        {
            PH.Navigate(this, new LoginPage.LoginPage());
        }

        private void FormKelolaUser(object sender, EventArgs e)
        {
            PH.loadForm(MainPanel,new KelolaUser());
        }

        private void KelolaLaporan(object sender, EventArgs e)
        {
            PH.loadForm(MainPanel, new LaporanPenjualan());
        }

        private void LogActivity(object sender, EventArgs e)
        {
            PH.loadForm(MainPanel, new LogPage());
        }
    }
}
