using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Employees
    {
        const string InsertEmployeeCommand = "INSERT INTO \"employees\"" +
            "(\"surname\", \"name\", \"lastname\", \"phone_number\", \"address\", \"specialization\", \"start_date\")" +
            "VALUES (@1, @2, @3, @4, @5, @6, @7)";

        internal static void Insert(object text1, object text2, object text3, object text4, object text5, object text6, object value)
        {
            throw new NotImplementedException();
        }

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
    }
}