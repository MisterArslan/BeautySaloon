namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Clients
    {
        const string InsertClientCommand = "INSERT INTO \"clients\"" +
            "(\"surname\", \"name\", \"phone_number\")" +
            " VALUES (@1, @2, @3)";

        const string UpdateClientCommand = "UPDATE \"clients\"" +
            " SET \"surname\" = @2, \"name\" = @3, \"phone_number\" = @4" +
            " WHERE \"clientID\" = @1";

        const string DeleteClientCommand = "DELETE FROM \"clients\"" +
            " WHERE \"clientID\" = @1";

        public static void Insert(string surname, string name, string phone_number)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertClientCommand;
                cmd.Parameters.AddWithValue("1", surname);
                cmd.Parameters.AddWithValue("2", name);
                cmd.Parameters.AddWithValue("3", phone_number);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Update(int clientID, string surname, string name, string phone_number)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = UpdateClientCommand;
                cmd.Parameters.AddWithValue("1", clientID);
                cmd.Parameters.AddWithValue("2", surname);
                cmd.Parameters.AddWithValue("3", name);
                cmd.Parameters.AddWithValue("4", phone_number);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }

        public static void Delete(int clientID)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = DeleteClientCommand;
                cmd.Parameters.AddWithValue("1", clientID);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}