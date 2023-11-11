using System.Data.SqlClient;

namespace ADO.NET_Console_CRUD_application.Context
{
    public class SqlWriterContext
    {
        private static SqlWriterContext instance;
        public static SqlWriterContext Instance=>instance??(instance = new SqlWriterContext());
     
        private SqlConnection connection;
        private SqlCommand command;
        private SqlWriterContext()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            connection.ConnectionString = Configuration.ConnectionString;
            command.Connection = connection;
        }
        public void UserInsertData(
            string firstName,
            string lastName,
            string country,
            DateTime date,
            string email,
            bool isFemale,
            int professionId)
        {

            command.CommandText = "INSERT INTO Users (FirstName,LastName,DayOfBirth,Country,Email,IsFemale,CreatedDate,ProfessionId) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";


            command.Parameters.AddWithValue("@p1", firstName);
            command.Parameters.AddWithValue("@p2", lastName);
            command.Parameters.AddWithValue("@p3", date);
            command.Parameters.AddWithValue("@p4", country);
            command.Parameters.AddWithValue("@p5", email);
            command.Parameters.AddWithValue("@p6", isFemale);
            command.Parameters.AddWithValue("@p7", DateTime.UtcNow);
            command.Parameters.AddWithValue("@p8", professionId);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UserUpdateData(
            int id,
            string firstName,
            string lastName,
            DateTime date,
            string country,
            string email,
            int professionId)
        {
            command.CommandText = "UPDATE Users SET FirstName=@p1,LastName=@p2,DayOfBirth=@p3,Country=@p4,Email=@p5,ProfessionId=@p6 WHERE Id=@p7";

            command.Parameters.AddWithValue("@p1", firstName);
            command.Parameters.AddWithValue("@p2", lastName);
            command.Parameters.AddWithValue("@p3", date);
            command.Parameters.AddWithValue("@p4", country);
            command.Parameters.AddWithValue("@p5", email);
            command.Parameters.AddWithValue("@p6", professionId);
            command.Parameters.AddWithValue("@p7", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void UserDeleteData(int id)
        {
            command.CommandText = "DELETE FROM Users WHERE Id=@p1";

            command.Parameters.AddWithValue("@p1", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ProfessionInsertData(string professionName)
        {
            command.CommandText = "INSERT INTO Professions (ProfessionName,CreatedDate) Values (@p1,@p2)";

            command.Parameters.AddWithValue("@p1",professionName);
            command.Parameters.AddWithValue("@p2",DateTime.Now);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void ProfessionUpdateData(int id,string professionName)
        {
            command.CommandText = "UPDATE Professions SET ProfessionName=@p1 WHERE Id=@p2";

            command.Parameters.AddWithValue("@p1",professionName);
            command.Parameters.AddWithValue("@p2",id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            command.Parameters.Clear();
        }

        public void ProfessionDeleteData(int id)
        {
            command.CommandText = "DELETE FROM Professions WHERE Id=@p1";

            command.Parameters.AddWithValue("@p1", id);

            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
