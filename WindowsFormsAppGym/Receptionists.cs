using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppGym
{
    public partial class Receptionists : Form
    {
        public Receptionists()
        {
            InitializeComponent();
        }
        string con = "datasource=127.0.0.1;port=3306;username=root;password=;database=gym_management";
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Receptionists_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT RecepID FROM receptionists_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            conn.Open();
            MySqlDataReader myReader = queryCmd.ExecuteReader();

            while (myReader.Read())
            {
                cBoxRecepId.Items.Add(myReader["RecepID"].ToString());
            }
        }

        

        private void btnRecepSave_Click(object sender, EventArgs e)
        {
            string Name = txtRecepName.Text;
            string Gender = cBoxRecepGender.Text;
            string DOB = dTimeRecepDOB.Value.ToString("yyyy-MM-dd");
            string Phone = txtRecepPhone.Text;
            string Address = txtRecepAddress.Text;
            string Password = txtRecepPassword.Text;

            MySqlConnection conn = new MySqlConnection(con);
            string query = "INSERT INTO receptionists_table(Name,Gender,DOB,Phone,Address,Password) VALUES ('" + Name + "','" + Gender + "','" + DOB.ToString() + "','" + Phone + "','" + Address + "','" + Password + "')";
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

        private void btnRecepSearch_Click(object sender, EventArgs e)
        {
            int RecepId = Convert.ToInt32(cBoxRecepId.Text);

            MySqlConnection conn = new MySqlConnection(con);

            string query = "SELECT Name,Gender,DOB,Phone,Address,Password FROM receptionists_table WHERE RecepID = '" + RecepId + "'";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);
            MySqlDataAdapter ap = new MySqlDataAdapter(queryCmd);
            DataSet ds = new DataSet();
            ap.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    txtRecepName.Text = ds.Tables[0].Rows[0]["Name"].ToString();
                    cBoxRecepGender.Text = ds.Tables[0].Rows[0]["Gender"].ToString();
                    dTimeRecepDOB.Text = ds.Tables[0].Rows[0]["DOB"].ToString();
                    txtRecepPhone.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                    txtRecepAddress.Text = ds.Tables[0].Rows[0]["Address"].ToString();
                    txtRecepPassword.Text = ds.Tables[0].Rows[0]["Password"].ToString();

                    dataGridViewRecep.DataSource = ds.Tables[0].Rows[0].ToString();
                }


        }

        private void btnRecepEdit_Click(object sender, EventArgs e)
        {
            int RecepId = Convert.ToInt32(cBoxRecepId.Text);

            string Name = txtRecepName.Text;
            string Gender = cBoxRecepGender.Text;
            string DOB = dTimeRecepDOB.Value.ToString("yyyy-MM-dd");
            string Phone = txtRecepPhone.Text;
            string Address = txtRecepAddress.Text;
            string Password = txtRecepPassword.Text;

            MySqlConnection conn = new MySqlConnection(con);
            string query = "UPDATE receptionists_table SET Name='" + Name + "',Gender='" + Gender + "',DOB='" + DOB + "',Phone='" + Phone + "',Address='" + Address + "',Password='" + Password + "' WHERE RecepID='" + RecepId + "'";
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

        private void btnRecepDelete_Click(object sender, EventArgs e)
        {
            int RecepId = Convert.ToInt32(cBoxRecepId.Text);

            MySqlConnection conCmd = new MySqlConnection(con);
            string query1 = "DELETE From receptionists_table where RecepID='" + cBoxRecepId.Text + "'";
            MySqlCommand queryCmd = new MySqlCommand(query1, conCmd);

            conCmd.Open();

            MySqlDataReader myReader = queryCmd.ExecuteReader();

            MessageBox.Show(" succesfully Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRecepPrevious_Click_1(object sender, EventArgs e)
        {
            Memberships loginForm1 = new Memberships();
            loginForm1.Show();
        }

        private void btnRecepRefresh_Click(object sender, EventArgs e)
        {
            txtRecepName.Clear();
            cBoxRecepGender.ResetText();
            dTimeRecepDOB.ResetText();
            txtRecepPhone.Clear();
            txtRecepAddress.Clear();
            txtRecepPassword.Clear();
        }

        private void btnRecepView_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(con);
            string query = "SELECT RecepID,Name,Gender,DOB,Phone,Address FROM receptionists_table";
            MySqlCommand queryCmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = queryCmd.ExecuteReader();

                while (myReader.Read())
                {
                    dataGridViewRecep.Rows.Add(myReader.GetInt32(0), myReader.GetString(1), myReader.GetString(2), myReader.GetDateTime(3).ToString("yyyy-MM-dd"), myReader.GetString(4), myReader.GetString(5));

                }
                MessageBox.Show("Receptionist List Viewed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnRecepNext_Click_1(object sender, EventArgs e)
        {
            Billing loginForm2 = new Billing();
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

        private void cBoxRecepId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
