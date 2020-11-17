using System;
using System.Windows.Forms;
using System.Media;
using System.Data.SqlClient;
namespace PTLABPROJECT
{

    public partial class Form2 : Form
    {
        public static int a ;
        int seat = 0;
        int cost = 0;
        public Form2()
        {
            
            InitializeComponent();
            cname.Text = details.name;
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "D:\\downloads 4\\maratheme.wav";
            player.Play();
            label1.Text = seat.ToString();
        }

        void defaultcombo(ComboBox ComboBox1)
        {
            if (ComboBox1.SelectedIndex < 0) ComboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            defaultcombo(comboBox1);
            defaultcombo(comboBox2);
            defaultcombo(comboBox3);
            a = comboBox1.SelectedIndex +1 ;
            
            Form1 frm = new Form1();
            frm.ShowDialog();
            seat = details.seatno;
            button1.Text = "CHANGE SEAT";
            label1.Text = seat.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                cost = 1999;
            if (comboBox1.SelectedIndex == 1)
                cost = 899;
            if (comboBox1.SelectedIndex == 2)
                cost = 1;
            labelcost.Text = cost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            details.fromindex = comboBox2.SelectedIndex;
            details.toindex = comboBox3.SelectedIndex;
            details.bookingdate = dateTimePicker1.Value;
            details.seatno = seat;
            details.cls = comboBox1.SelectedItem.ToString();
            string commandText = "UPDATE SEAT SET status = 1 WHERE s_no ="+seat+";";

            using (SqlConnection conn = new SqlConnection(@details.dbstring))
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            details.insert_table();
            int bookingid = details.bidv() - 1;
            MessageBox.Show("Ticket Booked Successfuly : " + seat +"\n BOOKING ID : "+bookingid);

        }

    }
}
