namespace BeautySaloon.DataAcessObjects.Tables
{
    static class Discounts
    {
        const string InsertDiscountCommand = "INSERT INTO" +
            "\"discounts\" (\"share_id\", \"service_id\", \"value\")" +
            "VALUES (@1, @2, @3)";

        public static void Insert(int shareID, int serviceID, int value)
        {
            Database.Connect();
            using (var cmd = Database.Connection.CreateCommand())
            {
                cmd.CommandText = InsertDiscountCommand;
                cmd.Parameters.AddWithValue("1", shareID);
                cmd.Parameters.AddWithValue("2", serviceID);
                cmd.Parameters.AddWithValue("3", value);
                cmd.ExecuteNonQuery();
            }
            Database.Disconnect();
        }
    }
}