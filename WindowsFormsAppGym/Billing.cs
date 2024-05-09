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
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";
        private void Billing_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT Name FROM members_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            conn.Open();
            MySqlDataReader myReader = queryCmd.ExecuteReader();

            while (myReader.Read())
            {
                cBoxBillingMember.Items.Add(myReader["Name"].ToString());
            }
        }

        private void btnBillingConfirm_Click(object sender, EventArgs e)
        {
            string Member = cBoxBillingMember.Text;
            string Period = dateTimeBillingPeriod.Value.ToString("yyyy-MM-dd");
            string Date = dateTimeBillingDate.Value.ToString("yyyy-MM-dd");
            int Amount = Convert.ToInt32(txtBillingAmount.Text);

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO billing_table(Member,Period,BillingDate,Amount) VALUES ('" + Member + "','" + Period.ToString() + "','" + Date.ToString() + "','" + Amount.ToString() +"')";
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

        private void btnBillingCancel_Click(object sender, EventArgs e)
        {
            cBoxBillingMember.ResetText();
            dateTimeBillingPeriod.ResetText();
            dateTimeBillingDate.ResetText();
            txtBillingAmount.Clear();
                
        }

        private void btnBillingView_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT BillID,Member,Period,BillingDate,Amount FROM billing_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridViewBilling.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetDateTime(2).ToString("yyyy-MM-dd"), myReader.GetDateTime(3).ToString("yyyy-MM-dd"), myReader.GetInt32(4));

                }
                MessageBox.Show("Coach List Viewed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBillingPrevious_Click(object sender, EventArgs e)
        {
            Receptionists loginForm = new Receptionists();
            loginForm.Show();
        }

        private void labelCoach_Click(object sender, EventArgs e)
        {
            Coach loginForm1 = new Coach();
            loginForm1.Show();
        }

        private void labelMember_Click(object sender, EventArgs e)
        {
            Members loginForm2 = new Members();
            loginForm2.Show();
        }

        private void labelMembership_Click(object sender, EventArgs e)
        {
            Memberships loginForm3 = new Memberships();
            loginForm3.Show();
        }

        private void labelRecep_Click(object sender, EventArgs e)
        {
            Receptionists loginForm4 = new Receptionists();
            loginForm4.Show();
        }

        private void labelBilling_Click(object sender, EventArgs e)
        {
            Billing loginForm5 = new Billing();
            loginForm5.Show();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cBoxBillingMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
