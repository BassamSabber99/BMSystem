using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BMS
{
    public partial class UpdateAccountant : Form
    {
        public UpdateAccountant()
        {
            InitializeComponent();
        }

        private void updatecus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N0BITSB;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                if (firstname.Text == string.Empty || lastname.Text == string.Empty || phonenumber.Text == string.Empty || adress.Text == string.Empty || email.Text == string.Empty || password.Text == string.Empty || gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Fill All Fields Correctly");

                    return;
                }


                string accountantquery = "select * from Accountant where accountantID = '" + id.Text + "'";
                SqlDataAdapter daccountant = new SqlDataAdapter(accountantquery, con);
                DataTable dtblacc = new DataTable();
                daccountant.Fill(dtblacc);
                if (dtblacc.Rows.Count == 0)
                {
                    MessageBox.Show("Accountant Not Found ");
                    return;
                }

                con.Open();
                SqlCommand cmd = new SqlCommand("updateacc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@FName", firstname.Text);
                cmd.Parameters.AddWithValue("@LName", lastname.Text);
                cmd.Parameters.AddWithValue("@Phone", phonenumber.Text);
                cmd.Parameters.AddWithValue("@Addres", adress.Text);
                cmd.Parameters.AddWithValue("@ema", email.Text);
                cmd.Parameters.AddWithValue("@pass", password.Text);
                cmd.Parameters.AddWithValue("@gender", gender.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucessfully....!!");
                firstname.Clear();
                lastname.Clear();
                phonenumber.Clear();
                adress.Clear();
                email.Clear();
                password.Clear();
                id.Clear();
            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminHome adm = new AdminHome();
            this.Hide();
            adm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void UpdateAccountant_Load(object sender, EventArgs e)
        {

        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void phonenumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }

        private void lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (char.IsDigit(charr) )
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }


        }
    }
}
