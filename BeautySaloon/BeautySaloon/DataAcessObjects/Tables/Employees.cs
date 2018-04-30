using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Employees
    {
        const string InsertEmployeeCommand = "INSERT INTO \"employees\"" +
            "(\"surname\", \"name\", \"lastname\", \"phone_number\", \"address\", \"specialization\", \"start_date\")" +
            " VALUES (@1, @2, @3, @4, @5, @6, @7)";

        const string UpdateEmployeeCommand = "UPDATE \"employees\"" +
            " SET \"surname\" = @2, \"name\" = @3, \"lastname\" = @4, \"phone_number\" = @5, \"address\" = @6, \"specialization\" = @7, \"start_date\" = @8" +
            " WHERE \"employeeID\" = @1";

        const string DeleteEmployeeCommand = "DELETE FROM \"employees\"" +
            " WHERE \"employeeID\" = @1";

        public static void Insert(string surname, string name, string lastname, string phonenumber, string address, string specialization, DateTime startDate)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertEmployeeCommand;
                cmd.Parameters.AddWithValue("1", surname);
                cmd.Parameters.AddWithValue("2", name);
                cmd.Parameters.AddWithValue("3", lastname);
                cmd.Parameters.AddWithValue("4", phonenumber);
                cmd.Parameters.AddWithValue("5", address);
                cmd.Parameters.AddWithValue("6", specialization);
                var startDateString = string.Concat(startDate.Year.ToString(), '-',
                    startDate.Month.ToString(), '-', startDate.Day.ToString());
                cmd.Parameters.AddWithValue("7", startDateString);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Update(int employeeID, string surname, string name, string lastname, string phonenumber, string address, string specialization, DateTime startDate)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateEmployeeCommand;
                cmd.Parameters.AddWithValue("1", employeeID);
                cmd.Parameters.AddWithValue("2", surname);
                cmd.Parameters.AddWithValue("3", name);
                cmd.Parameters.AddWithValue("4", lastname);
                cmd.Parameters.AddWithValue("5", phonenumber);
                cmd.Parameters.AddWithValue("6", address);
                cmd.Parameters.AddWithValue("7", specialization);
                var startDateString = string.Concat(startDate.Year.ToString(), '-',
                    startDate.Month.ToString(), '-', startDate.Day.ToString());
                cmd.Parameters.AddWithValue("8", startDateString);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int employeeID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteEmployeeCommand;
                cmd.Parameters.AddWithValue("1", employeeID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}