using MySql.Data.MySqlClient;

namespace Softdev_activities.Forms
{
    public class DatabaseHelper
    {
        // Create the SQL database
        private string connectionString = "server=localhost;user=root;passowrd=";

        //using the MySqlConnection class to connect to the database
        //Creating id for the user for ez access to the database

        public int GetNextUserId()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT COALESCE(MAX(user_id), 0) FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    return (result != DBNull.Value) ? Convert.ToInt32(result) + 1 : 1;
                }
            }
        }

        public void InsertUser(string name, int age)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO users (user_id, name, age) VALUES (@user_id, @name, @age)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_id", GetNextUserId());
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@age", age);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}