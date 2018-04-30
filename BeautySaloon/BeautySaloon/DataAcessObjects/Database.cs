using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BeautySaloon.DataAcessObjects
{
    class Database
    {
        public readonly static SqlConnection Connection
            = new SqlConnection("Data Source=DESKTOP-JE4MHQF;Initial Catalog=beauty_saloon;Integrated Security=True");

        public static void Connect()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void Disconnect()
        {
            try
            {
                Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}