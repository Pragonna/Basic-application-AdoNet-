

namespace Quizzes.Quizzes
{
    internal class QuizCreatorA : IQuizCreator
    {
        private List<bool> resultScore;
        public List<bool> ResultScore { get => resultScore; set => resultScore = value; }

        private readonly Dictionary<string, string>[] questions;
        private readonly Dictionary<int, string>[] wrongAnswers;
        private int n = 0;
        string[] arr;

       


        public QuizCreatorA()
        {
            questions = QuizA.QuestionsAndCorrectAnswers;
            wrongAnswers = QuizA.WrongAnswers;

            arr = new string[4];
            resultScore = new List<bool>(5);
        }

        public void GenerateQuiz(out string quiz, out string[] ans)
        {

            if (n > 4)
            {
                quiz = null;
                ans = null;

                return;
            }

            var questions = this.questions[n];
            var answer =questions.Keys.First();
            var question = questions.Values.First();
            var wrongAnswer = wrongAnswers[n];


            var rnd =new Random().Next(3);

            for (int i = 0; i < 4; i++)
            {
                if (i != rnd)
                    arr[i] = wrongAnswer[i];
                else
                    arr[i] = answer;
            }

            n++;

            quiz = question;
            ans = arr;

        }


    }
}
