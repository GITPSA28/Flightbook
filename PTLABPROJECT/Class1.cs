using System;
using System.Data.SqlClient;

namespace PTLABPROJECT
{
    public class details
    {
        public static string[] fc = { "MAA", "PDY" , "TRZ" };
        public static string[] tc = { "BOM", "DEL","CCU" };
        public static int seatno;
        public static int fromindex;
        public static int toindex;
        public static string cls ="FirstClass";
        public static DateTime bookingdate;
        public static string name = "Aravind";
        public static string dbstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\ptlab\\PTLABPROJECT\\PTLABPROJECT\\Database1.mdf;Integrated Security=True";
        public static int bookingid;

        
        public static int bidv()
        {
            int update;
            string namecmd = "SELECT count(Id) from[Table]";
            using (SqlConnection conn = new SqlConnection(@details.dbstring))

            using (SqlCommand cmd = new SqlCommand(namecmd, conn))

            {
                conn.Open();
                update = Int32.Parse( cmd.ExecuteScalar().ToString());
                conn.Close();
            }
            return update+1;
        }

        public static void insert_table()
        {

            
            string commandText = "INSERT into [Table] (Id, fromindex, toindex, class, date, name,seat) VALUES ('"+bidv()+"', '"+fromindex+ "','" + toindex + "','" +cls + "','" + bookingdate.Date.ToString("dd/MM/yyyy") + "','" + name + "','" + seatno + "')";
            using (SqlConnection conn = new SqlConnection(@details.dbstring))
            using (SqlDataAdapter da = new SqlDataAdapter(commandText, conn))
            {
                conn.Open();
                da.SelectCommand.ExecuteNonQuery();
                conn.Close();
            }
            
        }
    }

    class Class1
    {


    }
}
