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
    public partial class Memberships : Form
    {
        public Memberships()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Memberships_Load(object sender, EventArgs e)
        {

        }

        private void btnMembershipSave_Click(object sender, EventArgs e)
        {
            string Name = txtMembershipName.Text;
            int Duration = Convert.ToInt32(txtMembershipDuration.Text);
            string Goal = txtMembershipGoal.Text;
            int Cost = Convert.ToInt32(txtMembershipCost.Text);

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO memberships_table(Name,Duration,Goal,Cost) VALUES ('" + Name + "','" + Duration.ToString() + "','" + Goal + "','" + Cost.ToString() + "')";
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

        private void btnMembershipSearch_Click(object sender, EventArgs e)
        {
            string Name = txtMembershipName.Text;

            MySqlConnection conn = new MySqlConnection(con);

            string query = "SELECT Duration,Goal,Cost FROM memberships_table WHERE Name = '" + Name + "'";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);
            MySqlDataAdapter ap = new MySqlDataAdapter(queryCmd);
            DataSet ds = new DataSet();
            ap.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                txtMembershipDuration.Text = ds.Tables[0].Rows[0]["Duration"].ToString();
                txtMembershipGoal.Text = ds.Tables[0].Rows[0]["Goal"].ToString();
                txtMembershipCost.Text = ds.Tables[0].Rows[0]["Cost"].ToString();

                dataGridViewMemberships.DataSource = ds.Tables[0].Rows[0].ToString();
            }
        }

        private void btnMembershipEdit_Click(object sender, EventArgs e)
        {
            string Name = txtMembershipName.Text;
            int Duration = Convert.ToInt32(txtMembershipDuration.Text);
            string Goal = txtMembershipGoal.Text;
            int Cost = Convert.ToInt32(txtMembershipCost.Text);

            MySqlConnection conn = new MySqlConnection(con);
            string query = "UPDATE memberships_table SET Duration='" + Duration + "',Goal='" + Goal + "',Cost='" + Cost + "' WHERE Name ='" + Name + "'";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();
                MessageBox.Show("Data Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMembershipDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "DELETE From memberships_table where Name='" + txtMembershipName.Text + "'";
            MySqlCommand queryCmd = new MySqlCommand(query1, conCmd);

            conCmd.Open();

            MySqlDataReader myReader = queryCmd.ExecuteReader();

            MessageBox.Show(" succesfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMembershipPrevious_Click(object sender, EventArgs e)
        {
            Members loginForm1 = new Members();
            loginForm1.Show();
        }

        private void btnMembershipRefresh_Click(object sender, EventArgs e)
        {
            txtMembershipName.Clear();
            txtMembershipDuration.Clear();
            txtMembershipGoal.Clear();
            txtMembershipCost.Clear();
        }

        private void btnMembershipView_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT Name,Duration,Goal,Cost FROM memberships_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridViewMemberships.Rows.Add(myReader.GetString(0),myReader.GetInt32(1), myReader.GetString(2), myReader.GetInt32(3));

                }
                MessageBox.Show("Memberships List Viewed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMembershipNext_Click(object sender, EventArgs e)
        {
            Receptionists loginForm2 = new Receptionists();
            loginForm2.Show();
        }

        private void labelCoach_Click(object sender, EventArgs e)
        {
            Coach loginForm3 = new Coach();
            loginForm3.Show();
        }

        private void labelMember_Click(object sender, EventArgs e)
        {
            Members loginForm4 = new Members();
            loginForm4.Show();
        }

        private void labelMembership_Click(object sender, EventArgs e)
        {
            Memberships loginForm5 = new Memberships();
            loginForm5.Show();
        }

        private void labelRecep_Click(object sender, EventArgs e)
        {
            Receptionists loginForm6 = new Receptionists();
            loginForm6.Show();
        }

        private void labelBilling_Click(object sender, EventArgs e)
        {
            Billing loginForm7 = new Billing();
            loginForm7.Show();
        }

        private void labelLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
