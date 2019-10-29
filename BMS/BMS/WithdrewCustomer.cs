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
    public partial class WithdrewCustomer : Form
    {
        public WithdrewCustomer()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CustomerHome cus = new CustomerHome(globalvariable.value);
            this.Hide();
            cus.Show();

        }

        private void with_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-N0BITSB;Initial Catalog=BMS;Integrated Security=True");
            try
            {
                con.Open();
                if (withmon.Text == string.Empty)
                {
                    MessageBox.Show("Fill All Fields Correctly");
                    return;
                }
                string cuswith = "select* from Customer where Customer_ID = '" + globalvariable.value + "' and totalBalance >= '" + withmon.Text + "'";
                SqlDataAdapter dwith = new SqlDataAdapter(cuswith, con);
                DataTable dtblwith = new DataTable();
                dwith.Fill(dtblwith);
                if (dtblwith.Rows.Count == 0)
                {
                    MessageBox.Show("your balance is not enough");
                    return;
                }

                SqlCommand cmd = new SqlCommand("withdraws", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@withdrewmoney", withmon.Text);
                cmd.Parameters.AddWithValue("@id", globalvariable.value);
                SqlParameter outparam = new SqlParameter();
                outparam.ParameterName = "@total";
                outparam.SqlDbType = System.Data.SqlDbType.Int;
                outparam.Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add(outparam);
                cmd.ExecuteNonQuery();
                string total = outparam.Value.ToString();
                MessageBox.Show("Sucessfully!! total balance is :" + total);
                withmon.Clear();
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

      

        private void WithdrewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void withmon_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char charr = e.KeyChar;
            if (!char.IsDigit(charr) && charr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Cannot be Characters");
            }
        }
    }
}
