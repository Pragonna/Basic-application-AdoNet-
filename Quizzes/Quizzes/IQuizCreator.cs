namespace Quizzes.Quizzes
{
    internal interface IQuizCreator
    {
        List<bool> ResultScore { get; set; }

        void GenerateQuiz(out string quiz, out string[] ans);
    }
}