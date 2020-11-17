using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PTLABPROJECT
{
    public partial class Form3 : Form
    {
        public string assign(string namecmd)
        {
            string update;
            using (SqlConnection conn = new SqlConnection(@details.dbstring))

            using (SqlCommand cmd = new SqlCommand(namecmd, conn))

            {
                conn.Open();
                update = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            return update;
        }
        public DateTime assigndate(string namecmd)
        {
            DateTime date;
            using (SqlConnection conn = new SqlConnection(@details.dbstring))

            using (SqlCommand cmd = new SqlCommand(namecmd, conn))

            {
                conn.Open();
                date = DateTime.Parse( cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            return date;
        }
        
        public Form3()
        {
            int bid=details.bookingid;
            string[] cmds= new string[6];
            string[] clms = { "name", "fromindex", "toindex", "date", "seat" ,"class"};
            cmds[0]= "Select "+clms[0]+" from [Table] where Id = " + bid;
            
            for(int i=0;i<6;i++)
            {
                cmds[i] = "Select " + clms[i] + " from [Table] where Id = " + bid;
            }
            details.name = assign(cmds[0]);
            details.bookingdate = assigndate(cmds[3]);
            details.fromindex = Int32.Parse( assign(cmds[1]));
            details.toindex = Int32.Parse(assign(cmds[2]));
            details.seatno = Int32.Parse(assign(cmds[4]));
            details.cls = assign(cmds[5]);
            string from = details.fc[details.fromindex];
            string to = details.tc[details.toindex];

            InitializeComponent();
            labelfrom.Text = from;
            labelto.Text = to;
            label9.Text = from + " TO " + to;
            label4.Text = details.name;
            label6.Text = details.bookingdate.Date.ToString("dd/MM/yyyy");
            label10.Text = details.seatno.ToString();
            label11.Text = details.cls;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
