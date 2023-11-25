using ADO.NET_Console_CRUD_application.Entities;
using ADO.NET_Console_CRUD_application.Enums;
using System.Data.SqlClient;


namespace ADO.NET_Console_CRUD_application.Context
{
    public class SqlReaderContext
    {
        public List<User> UserReadData()
        {
            List<User> users = new List<User>();

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                try
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "Select * from Users";
                    connection.Open();

                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            var obj = new User
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                ProfessionId = Convert.ToInt32(dr["ProfessionId"]),
                                DateOfBirth = Convert.ToDateTime(dr["DayOfBirth"]),
                                Country = dr["Country"].ToString(),
                                Email = dr["Email"].ToString(),
                                Gender = Convert.ToBoolean(dr["IsFemale"]) is true ? GenderType.Female : GenderType.Male,
                                CreatedDate = Convert.ToDateTime(dr["CreatedDate"].ToString())
                            };

                            users.Add(obj);
                        }

                    }

                    return users;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Have a problem in the your connection. Please try again..");
                    throw new Exception(@"Check your database [Database, Tables]");
                }
                finally
                {
                    Application.StartApplication();
                }
            }
        }

        public List<Profession> ProfessionsReadData()
        {
            try
            {
                List<Profession> professions = new List<Profession>();

                using (var connection = new SqlConnection(Configuration.ConnectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = "Select * from Professions";
                    connection.Open();

                    using (var dr = command.ExecuteReader())
                    {
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
                    }
                    return professions;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Have a problem in the your connection. Please try again..");
                throw new Exception(@"Check your database [Database, Tables]");
            }
            finally
            {
                Application.StartApplication();
            }
        }

        public List<UserProfession> GetUserProfession()
        {
            try
            {
                List<UserProfession> userWithProfessions = new List<UserProfession>();

                using (var connection = new SqlConnection(Configuration.ConnectionString))
                {
                    var command = connection.CreateCommand();
                    command.CommandText = @"SELECT
                                           u.Id,
                                           u.FirstName,
                                           u.LastName,
                                           u.Country,
                                           p.ProfessionName,
                                           u.DayOfBirth,
                                           u.IsFemale,
                                           u.CreatedDate
                                        FROM Users u
                                        JOIN Professions p ON u.ProfessionId = p.Id";

                    connection.Open();
                    using (var dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var obj = new UserProfession
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                FirstName = dr["FirstName"].ToString(),
                                LastName = dr["LastName"].ToString(),
                                Country = dr["Country"].ToString(),
                                ProfessionName = dr["ProfessionName"].ToString(),
                                DateTime = DateTime.Parse(dr["DayOfBirth"].ToString()),
                                Gender = Convert.ToBoolean(dr["IsFemale"]) is true ? GenderType.Female : GenderType.Male,
                                CreatedDate = DateTime.Parse(dr["CreatedDate"].ToString())
                            };

                            userWithProfessions.Add(obj);
                        }

                    }

                    return userWithProfessions;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Have a problem in the your connection. Please try again..");
                throw new Exception(@"Check your database [Database, Tables]");
            }
            finally
            {
                Application.StartApplication();
            }
        }
    }
}

