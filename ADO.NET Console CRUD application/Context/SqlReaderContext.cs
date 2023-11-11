using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Entities.Common;
using System.Data.SqlClient;


namespace ADO.NET_Console_CRUD_application.Context
{
    public class SqlReaderContext
    {
        private SqlConnection connection;
        private SqlCommand command;
        public SqlReaderContext()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            connection.ConnectionString = Configuration.ConnectionString;
            command.Connection = connection;
        }
        public List<User> UserReadData()
        {
            List<User> users = new List<User>();

            string cmd = "Select * from Users";
            command.CommandText = cmd;
            connection.Open();
            var dr = command.ExecuteReader();

            while (dr.Read())
            {
                var isFemale = Convert.ToBoolean(dr["IsFemale"]);

                var obj = new User
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    FirstName = dr["FirstName"].ToString(),
                    LastName = dr["LastName"].ToString(),
                    ProfessionId = Convert.ToInt32(dr["ProfessionId"]),
                    DateOfBirth = Convert.ToDateTime(dr["DayOfBirth"]),
                    Country = dr["Country"].ToString(),
                    Email = dr["Email"].ToString(),
                    Gender = isFemale is true ? GenderType.Female : GenderType.Male,
                    CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString())
                };

                users.Add(obj);
            }
            connection.Close();

            return users;
        }

        public List<Profession> ProfessionsReadData()
        {
            List<Profession> professions = new List<Profession>();

            string cmd = "Select * from Professions";
            command.CommandText = cmd;
            connection.Open();
            var dr = command.ExecuteReader();

            while (dr.Read())
            {
                var obj = new Profession
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    ProfessionName = dr["ProfessionName"].ToString(),
                    CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString())
                };

                professions.Add(obj);
            }
            connection.Close();

            return professions;
        }
        public List<UserWithProfession> GetUserProfession()
        {
            List<UserWithProfession> userWithProfessions = new List<UserWithProfession>();

            bool isFemale = false;

            string cmd = "SELECT Users.Id,Users.FirstName, Users.LastName,Users.Country, Professions.ProfessionName,Users.DayOfBirth,Users.IsFemale,Users.CreatedDate\r\nFROM Users JOIN Professions ON Users.ProfessionId=Professions.Id";

            command.CommandText = cmd;

            connection.Open();
            var dr = command.ExecuteReader();

            while (dr.Read())
            {
                isFemale = dr.GetBoolean(6);

                var obj = new UserWithProfession
                {
                    Id = dr.GetInt32(0),
                    FirstName = dr.GetString(1),
                    LastName = dr.GetString(2),
                    Country = dr.GetString(3),
                    ProfessionName = dr.GetString(4),
                    DateTime = dr.GetDateTime(5),
                    Gender = isFemale is true ? GenderType.Female : GenderType.Male,
                    CreatedDate = dr.GetDateTime(7)
                };

                userWithProfessions.Add(obj);
            }
            connection.Close();

            return userWithProfessions;
        }
    }
}
