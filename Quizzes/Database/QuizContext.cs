using Microsoft.Data.SqlClient;


namespace Quizzes.Database
{
    public class QuizContext
    {
        private static QuizContext instance;
        public static QuizContext Instance=>instance??= new QuizContext();

        private  SqlCommand command;
        private  SqlConnection connection;

        private  QuizContext()
        {
            connection = new SqlConnection();
            command = new SqlCommand();
            connection.ConnectionString = Configuration.GetConnectionString;
            command.Connection = connection;
        }



        public  Dictionary<int, string> GetAllQuestion
        {
            get
            {
                var questions = new Dictionary<int, string>();

                command.CommandText = "SELECT * FROM QuizB";

                connection.Open();
                var dr = command.ExecuteReader();

                while (dr.Read())
                    questions.Add(dr.GetInt32(0), dr.GetString(1));

                connection.Close();

                return questions;
            }
        }

        public  Dictionary<int, string> GetAllAnswers
        {
            get
            {
                var answers = new Dictionary<int, string>();

                command.CommandText = "SELECT * FROM CorrectAnswer";
                connection.Open();
                var dr = command.ExecuteReader();

                while (dr.Read())
                    answers.Add(dr.GetInt32(0), dr.GetString(1));
                connection.Close();
                return answers;
            }
        }

        public  List<Dictionary<int, string>> GetAllWrongAnswers
        {
            get
            {
                int key = 0;

                var wrongAnswers = new List<Dictionary<int, string>>();
                var dictionary = new Dictionary<int, string>();

                command.CommandText = "SELECT * FROM WrongAnswer";
                connection.Open();
                var dr = command.ExecuteReader();

                while (dr.Read())
                {
                    if (key > 3)
                    {
                        key = 0;
                        wrongAnswers.Add(dictionary);
                        dictionary = new Dictionary<int, string>();
                    }

                    dictionary.Add(key, dr.GetString(1));
                    key++;
                }

                wrongAnswers.Add(dictionary);

                connection.Close();

                return wrongAnswers;
            }
        }
    }
}
