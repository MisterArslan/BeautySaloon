using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Records
    {
        const string InsertRecordCommand = "INSERT INTO \"records\"" +
            "(\"client_id\", \"employee_id\", \"service_id\", \"date\", \"time\", \"comment\")" +
            "VALUES (@1, @2, @3, @4, @5, @6)";

        const string UpdateRecordCommand = "UPDATE \"records\"" +
            " SET \"client_id\" = @2, \"employee_id\" = @3, \"service_id\" = @4, \"date\" = @5, \"time\" = @6, \"comment\" = @7" +
            " WHERE \"recordID\" = @1";

        const string DeleteRecordCommand = "DELETE FROM \"records\"" +
            " WHERE \"recordID\" = @1";

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

        public static void Update(int recordID, int clientID, int employeeID, int serviceID, DateTime dateTime, string comment)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateRecordCommand;
                cmd.Parameters.AddWithValue("1", recordID);
                cmd.Parameters.AddWithValue("2", clientID);
                cmd.Parameters.AddWithValue("3", employeeID);
                cmd.Parameters.AddWithValue("4", serviceID);
                var date = string.Concat(dateTime.Year.ToString(), '-',
                    dateTime.Month.ToString(), '-', dateTime.Day.ToString());
                var time = string.Concat(dateTime.Hour.ToString(), ':', dateTime.Minute.ToString());
                cmd.Parameters.AddWithValue("5", date);
                cmd.Parameters.AddWithValue("6", time);
                cmd.Parameters.AddWithValue("7", comment);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int recordID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteRecordCommand;
                cmd.Parameters.AddWithValue("1", recordID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}