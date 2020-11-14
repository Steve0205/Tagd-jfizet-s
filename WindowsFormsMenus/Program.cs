using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsMenus
{
    static class Program
    {
        public static TagModositas tagModositas = null;
        public static Taguj taguj = null;
        public static Lekerdezes lekerdezes= null;
        public static Ujbefizetes ujbefizetes = null;
        public static Form1 nyito = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            tagModositas = new TagModositas();
            taguj = new Taguj();
            nyito = new Form1();
            lekerdezes = new Lekerdezes();
            ujbefizetes = new Ujbefizetes();
            Application.Run(nyito);
        }
    }
}
