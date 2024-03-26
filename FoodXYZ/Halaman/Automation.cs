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
        public void LoginCheck(TextBox user, TextBox pass, Form page1, Form page2)
        {
            if (user.Text == "Fajar" && pass.Text == "Fajar123")
            {
                Navigate(page1, page2);
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
    }
}
