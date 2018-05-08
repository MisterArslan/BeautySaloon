namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Discounts
    {
        // Шаблон команды для добавления записи
        const string InsertDiscountCommand = "INSERT INTO \"discounts\"" +
            "(\"share_id\", \"service_id\", \"value\")" +
            " VALUES (@1, @2, @3)";

        // Шаблон команды для изменения записи
        const string UpdateDiscountCommand = "UPDATE \"discounts\"" +
            " SET \"share_id\" = @2, \"service_id\" = @3, \"value\" = @4" +
            " WHERE \"discountID\" = @1";

        // Шаблон команды для удаления записи
        const string DeleteDiscountCommand = "DELETE FROM \"discounts\"" +
            " WHERE \"discountID\" = @1";

        // Метод для добавления в БД
        public static void Insert(int shareID, int serviceID, int value)
        {
            // Подключение к БД
            Database.Connect();
            // Составление команды с помощью соотвутствующей строки
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertDiscountCommand;
                cmd.Parameters.AddWithValue("1", shareID);
                cmd.Parameters.AddWithValue("2", serviceID);
                cmd.Parameters.AddWithValue("3", value);
                cmd.ExecuteNonQuery();
            }
            // Закрытие подключения
            Database.Disconnect();
        }

        public static void Update(int discountID, int shareID, int serviceID, int value)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateDiscountCommand;
                cmd.Parameters.AddWithValue("1", discountID);
                cmd.Parameters.AddWithValue("2", shareID);
                cmd.Parameters.AddWithValue("3", serviceID);
                cmd.Parameters.AddWithValue("4", value);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int discountID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteDiscountCommand;
                cmd.Parameters.AddWithValue("1", discountID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}