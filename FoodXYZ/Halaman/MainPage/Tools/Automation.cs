using FoodXYZ.Halaman.LoginPage;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman
{
    public class Automation
    {
        //Navigate Between Page
        public void Navigate(Form page1, Form page2)
        {
            page1.Hide();
            page2.Show();
        }
        //Login Checker
        public void LoginCheck(TextBox user, TextBox pass, Form page1)
        {
            if (user.Text == "Admin" && pass.Text == "adm")
            {
                Navigate(page1, new AdminPage.AdminPage());
            } else if (user.Text == "Gudang" && pass.Text == "gdg")
            {
                Navigate(page1, new GudangPage());
            } else if (user.Text == "Kasir" && pass.Text == "ksr")
            {
                Navigate(page1, new KasirPage());
            } else
            {
                Msg("Ops..", "Username atau Password tidak sesuai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //MessageBox
        public void Msg(String title, String desc, MessageBoxButtons type, MessageBoxIcon icon)
        {
            MessageBox.Show(desc, title, type, icon);
        }
        //resetTextbox
        public void resetTB(TextBox tb, String text)
        {
            tb.Text = text;
            tb.PasswordChar = '\0';
        }
        //to Dock the Form
        public void loadForm(Panel panel, Form f)
        {
            if (panel.Controls.Count > 0)
            {
                panel.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panel.Controls.Add(f);
            panel.Tag = f;
            f.Show();
        }
    }
}
