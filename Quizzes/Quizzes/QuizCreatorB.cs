
using Quizzes.Database;
using Quizzes.Quizzes.Questions;

namespace Quizzes.Quizzes
{
    internal class QuizCreatorB : IQuizCreator
    {
        private List<bool> resultScore;
        public List<bool> ResultScore { get => resultScore; set => resultScore = value; }

        private QuizB quizB;
        private readonly Dictionary<int, string> questions;
        private readonly Dictionary<int, string> answers;
        private int n = 1;
        string[] arr;

        Random random = new Random();


        public QuizCreatorB()
        {
           quizB =new QuizB();
            questions = quizB.Questions;
            answers = quizB.Answers;
            

            arr = new string[4];
            resultScore = new List<bool>(5);

        }

        public void GenerateQuiz(out string quiz, out string[] ans)
        {

            if (n > 5)
            {
                quiz = null;
                ans = null;

                return;
            }

            var question = questions[n];
            var answer = answers[n];
            var wrongAnswers = quizB.WrongAnswers(n);


            var rnd = random.Next(3);

            for (int i = 0; i < 4; i++)
            {
                if (i != rnd)
                    arr[i] = wrongAnswers[i];
                else
                    arr[i] = answer;
            }

            n++;

            quiz = question;
            ans = arr;

        }
    }
}
