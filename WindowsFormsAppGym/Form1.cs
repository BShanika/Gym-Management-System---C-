using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsAppGym
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if ((txtLoginName.Text != "") && (txtLoginPassword.Text != ""))
            {
                if (radioButton1.Checked)
                {
                    Coach loginForm = new Coach();
                    loginForm.Show();
                    MessageBox.Show("Login Successfully","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else if (radioButton2.Checked)
                {
                    Members loginForm = new Members();
                    loginForm.Show();
                    MessageBox.Show("Login Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             string Name = txtLoginName.Text;
             string password = txtLoginPassword.Text;

             MySqlConnection conn = new MySqlConnection(con);
             string query = "INSERT INTO login_table(UserName,Password) VALUES ('" + Name + "','" + password + "')";
             MySqlCommand queryCmd = new MySqlCommand(query, conn);

             try
             {
                 conn.Open();
                 MySqlDataReader myReader = queryCmd.ExecuteReader();
                 MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 conn.Close();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }

            }
            else
            {
                MessageBox.Show("Enter username or password", "Message",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
