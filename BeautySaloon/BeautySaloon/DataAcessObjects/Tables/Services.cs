namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Services
    {
        const string InsertServiceCommand = "INSERT INTO \"services\"" +
            "(\"name\", \"price\", \"comment\")" +
            "VALUES (@1, @2, @3)";

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
    }
}