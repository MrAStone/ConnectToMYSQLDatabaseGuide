using MySqlConnector;

namespace ConnectToMYSQLDatabaseGuide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // something added
            MySqlConnection c = new MySqlConnection("server=SERVER;uid=USERNAME;pwd=PASSWORD;database=DATABASENAME");
            c.Open();
            string SQL = "SELECT * FROM YOURTABLE";
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = c;
            cmd.CommandText = SQL;
            MySqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                Console.WriteLine(r["YOURCOLUMNNAME"].ToString());
            }
            c.Close();
            c.Open();
            SQL = "INSERT INTO YOURTABLE (YOURCOLUMNNAME) VALUES ('YOURVALUE')";
            cmd.CommandText = SQL;
            cmd.ExecuteNonQuery();


        }
    }
}
