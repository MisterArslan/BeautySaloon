using System;
using System.Data.SqlClient;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Shares
    {
        const string InsertShareCommand = "INSERT INTO \"shares\"" +
            "(\"name\", \"start_date\", \"expiration_date\")" +
            "VALUES (@1, @2, @3)";

        public static void Insert(string name, DateTime startDate, DateTime expirationDate)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertShareCommand;
                cmd.Parameters.AddWithValue("1", name);
                var startDateString = string.Concat(startDate.Year.ToString(), '-',
                    startDate.Month.ToString(), '-', startDate.Day.ToString());
                cmd.Parameters.AddWithValue("2", startDateString);
                var expirationDateString = string.Concat(expirationDate.Year.ToString(), '-',
                    expirationDate.Month.ToString(), '-', expirationDate.Day.ToString());
                cmd.Parameters.AddWithValue("3", expirationDateString);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}