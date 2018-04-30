namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Services
    {
        const string InsertServiceCommand = "INSERT INTO \"services\"" +
            "(\"name\", \"price\", \"comment\")" +
            " VALUES (@1, @2, @3)";

        const string UpdateServiceCommand = "UPDATE \"services\"" +
            " SET \"name\" = @2, \"price\" = @3, \"comment\" = @4" +
            " WHERE \"serviceID\" = @1";

        const string DeleteServiceCommand = "DELETE FROM \"services\"" +
            " WHERE \"serviceID\" = @1";

        public static void Insert(string name, int price, string comment)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertServiceCommand;
                cmd.Parameters.AddWithValue("1", name);
                cmd.Parameters.AddWithValue("2", price);
                cmd.Parameters.AddWithValue("3", comment);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Update(int serviceID, string name, int price, string comment)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateServiceCommand;
                cmd.Parameters.AddWithValue("1", serviceID);
                cmd.Parameters.AddWithValue("2", name);
                cmd.Parameters.AddWithValue("3", price);
                cmd.Parameters.AddWithValue("4", comment);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int serviceID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteServiceCommand;
                cmd.Parameters.AddWithValue("1", serviceID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}