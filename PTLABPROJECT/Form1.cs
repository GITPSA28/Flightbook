using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PTLABPROJECT
{
    public partial class Form1 : Form
    {
        public int ReturnValue1 { get; set; }
        int count = 1;
        int x = 1;
        int y = 0;
        int c = Form2.a;

        public bool savail(int s)
        {

            SqlConnection con = new SqlConnection(@details.dbstring); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM seat WHERE s_no='" + s + "' AND status='" + 1 + "'", con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                return true;
            }
            return false;
        }

        public Form1()
        {
            InitializeComponent();
            print_seats();
        }
        public bool Clas(int a, int i)
        {
            if (a == 1)
            {
                if (i > 12) return true;
            }

            if (a==2)
            {
                if (i < 13 | i > 36) return true;
            }
            
            if (a == 3)
            {
                if (i < 37) return true;
            }
            return false;
        }
        void print_seats()
        {
            for (int i = 1; i <= 41; i++)
            {
                Button b = new Button();
                b.Text = count.ToString();
                b.Name = count.ToString();
                b.Size = new Size(40, 40);
                if (Clas(c,i) | savail(i))
                {
                    b.BackColor = Color.FromArgb(255, 75, 75);
                    b.Cursor = Cursors.No;
                    b.Click += b_Click;
                    void b_Click(object sender, EventArgs e)
                    {
                        MessageBox.Show("Not available");
                    }
                }
                else
                {
                    
                    b.BackColor = Color.FromArgb(255, 255, 255);
                    b.Click += b_Click;
                    b.ForeColor= Color.FromArgb(0,0,0);
                    void b_Click(object sender, EventArgs e)
                    {
                        b.BackColor = Color.FromArgb(90, 250, 90);
                        details.seatno= Int32.Parse(b.Text);
                       // this.ReturnValue1 = Int32.Parse(b.Text);
                        MessageBox.Show("seat Selected : " + b.Text);
                        this.Close();
                        
                    }
                }

                b.Location = new Point(40 * x, 40 * (y + 1));
                y++;
                if(count%2==0 & count!=38 & count!=40)
                {
                    y++;
                }
                if (count % 4 == 0 & count!=40)
                {
                    x += 1;
                    y = 0;
                }

                if (count == 12 | count == 36 )
                {
                    x += 1;
                }
                count++;
                Controls.Add(b);
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@details.dbstring))
            for (int i = 1; i <= 41; i++)
            {
                string commandText = "UPDATE SEAT SET status = 0 WHERE s_no =" + i + ";";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        
        }
    }
}
