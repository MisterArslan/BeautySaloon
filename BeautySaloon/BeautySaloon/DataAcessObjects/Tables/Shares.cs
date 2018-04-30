using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Shares
    {
        const string InsertShareCommand = "INSERT INTO \"shares\"" +
            "(\"name\", \"start_date\", \"expiration_date\")" +
            " VALUES (@1, @2, @3)";

        const string UpdateShareCommand = "UPDATE \"shares\"" +
            " SET \"name\" = @2, \"start_date\" = @3, \"expiration_date\" = @4" +
            " WHERE \"shareID\" = @1";

        const string DeleteShareCommand = "DELETE FROM \"shares\"" +
            " WHERE \"shareID\" = @1";

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

        public static void Update(int shareID, string name, DateTime startDate, DateTime expirationDate)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateShareCommand;
                cmd.Parameters.AddWithValue("1", shareID);
                cmd.Parameters.AddWithValue("2", name);
                var startDateString = string.Concat(startDate.Year.ToString(), '-',
                    startDate.Month.ToString(), '-', startDate.Day.ToString());
                cmd.Parameters.AddWithValue("3", startDateString);
                var expirationDateString = string.Concat(expirationDate.Year.ToString(), '-',
                    expirationDate.Month.ToString(), '-', expirationDate.Day.ToString());
                cmd.Parameters.AddWithValue("4", expirationDateString);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int shareID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteShareCommand;
                cmd.Parameters.AddWithValue("1", shareID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}