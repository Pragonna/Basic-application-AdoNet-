public class QuizA
{
    private readonly static Dictionary<string, string>[] questionsAndCorrectanswers;
    private readonly static Dictionary<int, string>[] wrongAnswers;

    static QuizA()
    {

        questionsAndCorrectanswers = new Dictionary<string, string>[] { new(), new(), new(), new(), new() };

        wrongAnswers = new Dictionary<int, string>[] { new(), new(), new(), new(), new() };

        GetQuizzes();
    }

    public static Dictionary<string, string>[] QuestionsAndCorrectAnswers => questionsAndCorrectanswers;
    public static Dictionary<int, string>[] WrongAnswers => wrongAnswers;
    static void GetQuizzes()
    {

        questionsAndCorrectanswers[0].Add("0ans", "0");
        questionsAndCorrectanswers[1].Add("1ans", "1");
        questionsAndCorrectanswers[2].Add("2ans", "2");
        questionsAndCorrectanswers[3].Add("3ans", "3");
        questionsAndCorrectanswers[4].Add("4ans", "4");


        wrongAnswers[0].Add(0, "0w");
        wrongAnswers[0].Add(1, "1w");
        wrongAnswers[0].Add(2, "2w");
        wrongAnswers[0].Add(3, "3w");

        wrongAnswers[1].Add(0, "0w");
        wrongAnswers[1].Add(1, "1w");
        wrongAnswers[1].Add(2, "2w");
        wrongAnswers[1].Add(3, "3w");

        wrongAnswers[2].Add(0, "0w");
        wrongAnswers[2].Add(1, "1w");
        wrongAnswers[2].Add(2, "2w");
        wrongAnswers[2].Add(3, "3w");

        wrongAnswers[3].Add(0, "0w");
        wrongAnswers[3].Add(1, "1w");
        wrongAnswers[3].Add(2, "2w");
        wrongAnswers[3].Add(3, "3w"); ;

        wrongAnswers[4].Add(0, "0w");
        wrongAnswers[4].Add(1, "1w");
        wrongAnswers[4].Add(2, "2w");
        wrongAnswers[4].Add(3, "3w");
    }


}