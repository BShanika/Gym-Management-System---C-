using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppGym
{
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void Coach_Load(object sender, EventArgs e)
        {        
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT CoachID FROM coach_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            conn.Open();
            MySqlDataReader myReader = queryCmd.ExecuteReader();

            while (myReader.Read())
            {
                cBoxCoachID.Items.Add(myReader["CoachID"].ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCoachSave_Click(object sender, EventArgs e)
        {
            string Name = txtCoachName.Text;
            string Gender = cBoxCoachGender.Text;
            string DOB=dateTimeCoachDOB.Value.ToString("yyyy-MM-dd");
            string Phone = txtCoachPhone.Text;
            int Experience = Convert.ToInt32(txtCoachExperience.Text);
            string Address = txtCoachAddress.Text;
            string Password = txtCoachPassword.Text;

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO coach_table(Name,Gender,DOB,Phone,Experience,Address,Password) VALUES ('" + Name + "','" + Gender + "','" + DOB.ToString() + "','" + Phone + "','" + Experience + "','" + Address + "','" + Password + "')";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();
                MessageBox.Show("Data Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCoachSearch_Click(object sender, EventArgs e)
        {
            int CoachId = Convert.ToInt32(cBoxCoachID.Text);

            MySqlConnection conn = new MySqlConnection(con);

            string query= "SELECT CoachID,Name,Gender,DOB,Phone,Experience,Address,Password FROM coach_table WHERE CoachID = '"+ CoachId +"'";
            MySqlCommand queryCmd = new MySqlCommand(query,conn);
            MySqlDataAdapter ap = new MySqlDataAdapter(queryCmd);
            DataSet ds = new DataSet();
            ap.Fill(ds);
                 if (ds.Tables.Count > 0)
                 {
                    cBoxCoachID.Text = ds.Tables[0].Rows[0]["CoachID"].ToString();
                    txtCoachName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    cBoxCoachGender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
                    dateTimeCoachDOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
                    txtCoachPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                    txtCoachExperience.Text = ds.Tables[0].Rows[0]["Experience"].ToString();
                    txtCoachAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    txtCoachPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();

                    dataGridViewCoach.DataSource = ds.Tables[0].Rows[0].ToString();
                 }

        }

        private void btnCoachEdit_Click(object sender, EventArgs e)
        {
            int CoachId = Convert.ToInt32(cBoxCoachID.Text);
            string Name = txtCoachName.Text;
            string Gender = cBoxCoachGender.Text;
            string DOB = dateTimeCoachDOB.Value.ToString("yyyy-MM-dd");
            string Phone = txtCoachPhone.Text;
            int Experience = Convert.ToInt32(txtCoachExperience.Text);
            string Address = txtCoachAddress.Text;
            string Password = txtCoachPassword.Text;

            MySqlConnection conn = new MySqlConnection(con);
            string query = "UPDATE coach_table SET Name='"+Name+"',Gender='"+Gender+"',DOB='"+DOB+"',Phone='"+Phone+"',Experience='"+Experience+"',Address='"+Address+"',Password='"+Password+"' WHERE CoachID='"+CoachId+"'";
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

        private void btnCoachDelete_Click(object sender, EventArgs e)
        {
            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "DELETE From coach_table where Name='" + txtCoachName.Text + "'";
            MySqlCommand queryCmd = new MySqlCommand(query1, conCmd);

            conCmd.Open();

            MySqlDataReader myReader = queryCmd.ExecuteReader();

            MessageBox.Show(" succesfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCoachRefresh_Click(object sender, EventArgs e)
        {
            txtCoachName.Clear();
            cBoxCoachGender.ResetText();
            dateTimeCoachDOB.ResetText();
            txtCoachPhone.Clear();
            txtCoachExperience.Clear();
            txtCoachAddress.Clear();
            txtCoachPassword.Clear();
            cBoxCoachID.ResetText();
        }

        private void btnCoachView_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT CoachID,Name,Gender,DOB,Phone,Experience,Address FROM coach_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridViewCoach.Rows.Add(myReader.GetInt32(0),myReader.GetString(1),myReader.GetString(2),myReader.GetDateTime(3).ToString("yyyy-MM-dd"),myReader.GetString(4),myReader.GetInt32(5),myReader.GetString(6));

                }
                MessageBox.Show("Coach List Viewed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
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
    }
}
