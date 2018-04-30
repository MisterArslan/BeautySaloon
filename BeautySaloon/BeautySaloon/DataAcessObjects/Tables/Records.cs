using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Records
    {
        const string InsertRecordCommand = "INSERT INTO \"records\"" +
            "(\"client_id\", \"employee_id\", \"service_id\", \"date\", \"time\", \"comment\")" +
            "VALUES (@1, @2, @3, @4, @5, @6)";

        public static void Insert(int clientID, int employeeID, int serviceID, DateTime dateTime, string comment)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertRecordCommand;
                cmd.Parameters.AddWithValue("1", clientID);
                cmd.Parameters.AddWithValue("2", employeeID);
                cmd.Parameters.AddWithValue("3", serviceID);
                var date = string.Concat(dateTime.Year.ToString(), '-',
                    dateTime.Month.ToString(), '-', dateTime.Day.ToString());
                var time = string.Concat(dateTime.Hour.ToString(), ':', dateTime.Minute.ToString());
                cmd.Parameters.AddWithValue("4", date);
                cmd.Parameters.AddWithValue("5", time);
                cmd.Parameters.AddWithValue("6", comment);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}