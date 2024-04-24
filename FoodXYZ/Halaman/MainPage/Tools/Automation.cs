using FoodXYZ.Halaman.LoginPage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodXYZ.Halaman
{
    public class Automation
    {

        //Global Variable
        public bool Admin, Kasir, Gudang = false;
        public int CurrentIdUser;
        string StringCnn = "Data Source=DESKTOP-B6V1J3A;Initial Catalog=foodxyz;Integrated Security=True;";


        //Navigate Between Page
        public void Navigate(Form page1, Form page2)
        {
            page1.Hide();
            page2.Show();
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


        //LoginCheck
        public void LoginCheck(string query, Form currentForm)
        {
            //Login Checker
            Login(query);

            if (Admin == true)
            {
                currentForm.Hide(); new AdminPage.AdminPage().Show();

                //Save log
                CmdSql("insert into tbl_log(waktu, aktivitas, id_user) values ('" +  + "', 'Login', '" + CurrentIdUser + ")");
            }
            else if (Gudang == true) 
            { 
                currentForm.Hide(); new GudangPage().Show();

                //Save log
                CmdSql("insert into tbl_log(waktu, aktivitas, id_user) values ('" + DateTime.Now + "', 'Login', '" + CurrentIdUser + ")");
            }
            else if (Kasir == true)
            {
                currentForm.Hide(); new KasirPage().Show();

                //Save log
                CmdSql("insert into tbl_log(waktu, aktivitas, id_user) values ('" + DateTime.Now + "', 'Login', '" + CurrentIdUser + ")");
            }
        }


        /*Connection Function*/

        //Connection to DB
        public void CmdSql(String query)
        {
            SqlConnection cnn = new SqlConnection(StringCnn);
            cnn.Open();
            try 
            {
                SqlCommand cmd = new SqlCommand(query, cnn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
            } catch (Exception ex)
            {
                Msg("Ops !", ex.ToString(),  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                cnn.Close();
            }
        }
        //Get Data
        public void Login(string query)
        {
            SqlConnection cnn = new SqlConnection(StringCnn);
            cnn.Open();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows[0][0].ToString() == "admin") Admin = true;
                if (dt.Rows[0][0].ToString() == "cashier") Kasir = true;
                if (dt.Rows[0][0].ToString() == "gudang") Gudang = true;

                //Msg("Ops", dt.Rows[0][1].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentIdUser = Int32.Parse(dt.Rows[0][1].ToString());
            }
            catch (Exception ex)
            {
                //Msg("Ops", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                Msg("Ops", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
