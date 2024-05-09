using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppGym
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Members_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT Name FROM coach_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);
            string query1 = "SELECT MemberID FROM members_table";
            MySqlCommand queryCmd1 = new MySqlCommand(query1, conn);

            conn.Open();
            MySqlDataReader myReader = queryCmd.ExecuteReader();

            while (myReader.Read())
            {
                cBoxMemberCoach.Items.Add(myReader["Name"].ToString());
            }
            conn.Close();

            conn.Open();
            MySqlDataReader myReader1 = queryCmd1.ExecuteReader();

            while (myReader1.Read())
            {
                cBoxMemberId.Items.Add(myReader1["MemberID"].ToString());
            }
            conn.Close();
        }

        private void btnMemberSave_Click(object sender, EventArgs e)
        {
            string Name = txtMemberName.Text;
            string Gender = cBoxMemberGender.Text;
            string DOB = dateTimeMemberDOB.Value.ToString("yyyy-MM-dd");
            string Date = dateTimeMemberDate.Value.ToString("yyyy-MM-dd");
            string Membership = cBoxMemberMembership.Text;
            string Phone = txtMemberPhone.Text;
            string Timing = cBoxMemberTiming.Text;
            string Status = cBoxMemberStatus.Text;
            string Coach = cBoxMemberCoach.Text;


            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO members_table(Name,Gender,DOB,JoinDate,Memberships,Phone,Timing,Status,Coach) VALUES ('" + Name + "','" + Gender + "','" + DOB.ToString() + "','" + Date.ToString() + "','" + Membership + "','" + Phone + "','" + Timing + "','" + Status + "','" + Coach + "')";
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

        private void btnMemberSearch_Click(object sender, EventArgs e)
        {
            int MemberId = Convert.ToInt32(cBoxMemberId.Text);

            MySqlConnection conn = new MySqlConnection(con);

            string query = "SELECT Name,Gender,DOB,JoinDate,Memberships,Phone,Timing,Status,Coach FROM members_table WHERE MemberID = '" + MemberId + "'";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);
            MySqlDataAdapter ap = new MySqlDataAdapter(queryCmd);
            DataSet ds = new DataSet();
            ap.Fill(ds);
            if (ds.Tables.Count > 0)
            {
                txtMemberName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                cBoxMemberGender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
                dateTimeMemberDOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
                dateTimeMemberDate.Text = ds.Tables[0].Rows[0]["JoinDate"].ToString();
                cBoxMemberMembership.Text = ds.Tables[0].Rows[0]["Memberships"].ToString();
                txtMemberPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                cBoxMemberTiming.Text = ds.Tables[0].Rows[0]["Timing"].ToString();
                cBoxMemberStatus.Text = ds.Tables[0].Rows[0]["Status"].ToString();
                cBoxMemberCoach.Text = ds.Tables[0].Rows[0]["Coach"].ToString();

                dataGridViewMembers.DataSource = ds.Tables[0].Rows[0].ToString();
            }

        }

        private void btnMemberEdit_Click(object sender, EventArgs e)
        {
            int MemberId = Convert.ToInt32(cBoxMemberId.Text);

            string Name = txtMemberName.Text;
            string Gender = cBoxMemberGender.Text;
            string DOB = dateTimeMemberDOB.Value.ToString("yyyy-MM-dd");
            string Date = dateTimeMemberDate.Value.ToString("yyyy-MM-dd");
            string Membership = cBoxMemberMembership.Text;
            string Phone = txtMemberPhone.Text;
            string Timing = cBoxMemberTiming.Text;
            string Status = cBoxMemberStatus.Text;
            string Coach = cBoxMemberCoach.Text;

            MySqlConnection conn = new MySqlConnection(con);
            string query = "UPDATE members_table SET Name='" + Name + "',Gender='" + Gender + "',DOB='" + DOB + "',JoinDate='" + Date + "',Memberships='" + Membership + "',Phone='" + Phone + "',Timing='" + Timing + "',Status='" + Status + "',Coach='" + Coach + "' WHERE MemberID='" + MemberId + "'";
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

        private void btnMemberDelete_Click(object sender, EventArgs e)
        {
            int MemberId = Convert.ToInt32(cBoxMemberId.Text);

            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "DELETE From members_table where MemberID='" + cBoxMemberId.Text + "'";
            MySqlCommand queryCmd = new MySqlCommand(query1, conCmd);

            conCmd.Open();

            MySqlDataReader myReader = queryCmd.ExecuteReader();

            MessageBox.Show(" succesfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void btnMemberRefresh_Click(object sender, EventArgs e)
        {
            txtMemberName.Clear();
            cBoxMemberGender.ResetText();
            dateTimeMemberDOB.ResetText();
            dateTimeMemberDate.ResetText();
            cBoxMemberMembership.ResetText();
            txtMemberPhone.Clear();
            cBoxMemberTiming.ResetText();
            cBoxMemberStatus.ResetText();
            cBoxMemberCoach.ResetText();
        }

        private void btnMemberView_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT MemberID,Name,Gender,DOB,JoinDate,Memberships,Phone,Timing,Status,Coach FROM members_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridViewMembers.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetDateTime(3).ToString("yyyy-MM-dd"), myReader.GetDateTime(4).ToString("yyyy-MM-dd"), myReader.GetString(5), myReader.GetString(6), myReader.GetString(7), myReader.GetString(8), myReader.GetString(9));

                }
                MessageBox.Show("Members List Viewed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnMemberNext_Click(object sender, EventArgs e)
        {
            Memberships loginForm2 = new Memberships();
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

        private void cBoxMemberCoach_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
