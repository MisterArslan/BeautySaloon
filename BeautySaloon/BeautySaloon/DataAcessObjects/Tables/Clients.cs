namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Clients
    {
        const string InsertClientCommand = "INSERT INTO \"clients\"" +
            "(\"surname\", \"name\", \"phone_number\")" +
            "VALUES (@1, @2, @3)";

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
    }
}