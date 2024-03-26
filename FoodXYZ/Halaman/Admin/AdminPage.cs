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

        //Load Form
        public void loadForm(Object form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            Form f = form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            loadForm(new LogPage());
        }

        private void Logout(object sender, EventArgs e)
        {
            PH.Navigate(this, new LoginPage.LoginPage());
        }
    }
}
