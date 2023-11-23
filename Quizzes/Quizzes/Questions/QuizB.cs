using Quizzes.Database;
using System.CodeDom;

namespace Quizzes.Quizzes.Questions
{
    internal class QuizB
    {
        private QuizContext instance;

        public QuizB()
        {
            instance = QuizContext.Instance;
        }
        public Dictionary<int, string> Questions
        {
            get => instance.GetAllQuestion;
        }

        public Dictionary<int, string> Answers
        {
            get =>  instance.GetAllAnswers;
        }

        public Dictionary<int, string> WrongAnswers(int key)
        {
            switch (key)
            {
                case 1: return instance.GetAllWrongAnswers[0];
                case 2: return instance.GetAllWrongAnswers[1];
                case 3: return instance.GetAllWrongAnswers[2];
                case 4: return instance.GetAllWrongAnswers[3];
                default:
                return instance.GetAllWrongAnswers[4];
            }
            return default;
        }
    }
}
