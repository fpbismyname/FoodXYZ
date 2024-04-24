using FoodXYZ.Halaman.AdminPage;
using FoodXYZ.Halaman.LoginPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman.LoginPage
{
    public partial class LoginPage : Form
    { 
        
        //Variable & Call Function
        private string TB_USR = "Username", TB_PWD = "Password";
        Automation PH = new Automation();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void loadLoginPage(object sender, EventArgs e)
        {
            tb_user.Text = TB_USR;
            tb_passwd.Text = TB_PWD;
            tb_user.ForeColor = Color.Gray;
            tb_passwd.ForeColor = Color.Gray;
        }

        /** Placeholder
         Notes :    0 = Enter
                    1 = Leave
                    2 = Reset
         **/

        //Placeholder Username
        private void UserNameEnter(object sender, EventArgs e)
        {
            if (tb_user.Text == TB_USR)
            {
                tb_user.Text = "";
            }
        }
        private void UserNameLeave(object sender, EventArgs e)
        {
            if (tb_user.Text == "" || tb_user.Text == TB_USR)
            {
                tb_user.Text = TB_USR;
            }
        }


        //Placeholder Password
        private void PassEnter(object sender, EventArgs e)
        {
            if (tb_passwd.Text == TB_PWD)
            {
                tb_passwd.Text = "";
                tb_passwd.PasswordChar = '*';
            }
        }
        private void PassLeave(object sender, EventArgs e)
        {
            if (tb_passwd.Text == "" || tb_passwd.Text == TB_PWD)
            {
                tb_passwd.Text = TB_PWD;
                tb_passwd.PasswordChar = '\0';
            }
        }

        private void onClick(object sender, EventArgs e)
        {
            //PH.LoginCheck(tb_user, tb_passwd, this);
            PH.LoginCheck("Select tipe_user, id_user from tbl_user where username = '"+tb_user.Text+"' and password = '"+tb_passwd.Text+"';", this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Reset Username & Password
        private void onreset(object sender, EventArgs e)
        {
            PH.resetTB(tb_passwd, "Password");
            PH.resetTB(tb_user, "Username");
        }
    }
}
