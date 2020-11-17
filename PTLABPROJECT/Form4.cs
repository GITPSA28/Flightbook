using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTLABPROJECT
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i= Int32.Parse(textBox7.Text); ;
            if(i>0 & i<details.bidv())
            {
                details.bookingid = i;
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Booking ID");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(details.dbstring); 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM udata WHERE id='" + textBox1.Text + "' AND pass='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                string n = textBox1.Text;
                string cmds = "Select name from udata where Id = '" + n+"'";
                string update;
                using (SqlConnection conn = new SqlConnection(@details.dbstring))

                using (SqlCommand cmd = new SqlCommand(cmds, conn))

                {
                    conn.Open();
                    update = cmd.ExecuteScalar().ToString();
                    conn.Close();
                }
                details.name = update;
                new Form2().Show();
            }
            else
                MessageBox.Show("Invalid username or password");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string commandText = "INSERT into udata (Id, pass, name, email) VALUES ('" + textBox4.Text + "', '" + textBox3.Text + "','" + textBox6.Text + "','" + textBox5.Text +"')";
            using (SqlConnection conn = new SqlConnection(@details.dbstring))
            using (SqlDataAdapter da2 = new SqlDataAdapter(commandText, conn)) 
            {
                conn.Open();
                da2.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Signup succefull");
                conn.Close();
            }

        }
    }
}
