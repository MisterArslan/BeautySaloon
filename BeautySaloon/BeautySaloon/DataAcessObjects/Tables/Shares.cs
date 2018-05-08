using System;

namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Shares
    {
        // Шаблон команды для добавления записи
        const string InsertShareCommand = "INSERT INTO \"shares\"" +
            "(\"name\", \"start_date\", \"expiration_date\")" +
            " VALUES (@1, @2, @3)";

        // Шаблон команды для изменения записи
        const string UpdateShareCommand = "UPDATE \"shares\"" +
            " SET \"name\" = @2, \"start_date\" = @3, \"expiration_date\" = @4" +
            " WHERE \"shareID\" = @1";

        // Шаблон команды для удаления записи
        const string DeleteShareCommand = "DELETE FROM \"shares\"" +
            " WHERE \"shareID\" = @1";

        // Метод для добавления в БД
        public static void Insert(string name, DateTime startDate, DateTime expirationDate)
        {
            // Подключение к БД
            Database.Connect();
            // Составление команды с помощью соотвутствующей строки
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertShareCommand;
                cmd.Parameters.AddWithValue("1", name);
                // Преобразование даты в нужный формат для БД
                var startDateString = string.Concat(startDate.Year.ToString(), '-',
                    startDate.Month.ToString(), '-', startDate.Day.ToString());
                cmd.Parameters.AddWithValue("2", startDateString);
                // Преобразование даты в нужный формат для БД
                var expirationDateString = string.Concat(expirationDate.Year.ToString(), '-',
                    expirationDate.Month.ToString(), '-', expirationDate.Day.ToString());
                cmd.Parameters.AddWithValue("3", expirationDateString);
                cmd.ExecuteNonQuery();
            }
            // Закрытие подключения
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