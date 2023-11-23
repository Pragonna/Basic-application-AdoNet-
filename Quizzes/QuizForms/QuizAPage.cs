
using Quizzes.QuizForms;
using Quizzes.Quizzes;
using Quizzes.Quizzes.Questions;
using System.Windows.Forms;

namespace Quizzes
{
    public partial class QuizAPage : Form
    {

        private IQuizCreator quiz;
        private ResultForm resultInfo;
        private string question;
        private string[] answers;
        int countKey;
        int quizCount;
        public QuizAPage()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void QuizAPage_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            quiz = new QuizCreatorA();
            //resultInfo = new ResultForm();
            countKey = 1;
            quizCount=0;

            Next();
        }

        private void Next()
        {
            if (!string.IsNullOrEmpty(label1.Text))
                Thread.Sleep(1000);

            ButtonColorClear();

            quiz.GenerateQuiz(out question, out answers);

            label1.Text = question;
            labelKey.Text = countKey + ". ";

            var _answers = answers;

            if (string.IsNullOrEmpty(question) || answers is null)
                EndResult();
            else
            {
                btn1opt.Text = _answers[0];
                btn2opt.Text = _answers[1];
                btn3opt.Text = _answers[2];
                btn4opt.Text = _answers[3];

                quizCount++;
            }

            countKey++;
        }

        public void EndResult()
        {
            ButtonValueEmpty();

            int trueCount = 0;

            var arr = quiz.ResultScore;

            foreach (var item in arr)
            {
                if (item)
                    trueCount++;
            }

            var res = 100 / quizCount * trueCount;

            string message;

            if (res > 0)
                message = $"Test {res} % uğurla tamamlanmışdır.";
            else
                message = "Siz heç bir suala doğru cavab verməmisiniz.";

            ResultForm.ResultInfo=message;

            MessageBox.Show(message ,"Informasiya");

            Close();
        }

        private void ButtonColorClear()
        {
            btn1opt.BackColor = Color.White;
            btn2opt.BackColor = Color.White;
            btn3opt.BackColor = Color.White;
            btn4opt.BackColor = Color.White;
        }
        private void ButtonValueEmpty()
        {
            label1.Text = string.Empty;
            btn1opt.Text =string.Empty;
            btn2opt.Text =string.Empty;
            btn3opt.Text =string.Empty;
            btn4opt.Text =string.Empty;
            labelKey.Text = string.Empty;
        }

        private void btn1opt_Click(object sender, EventArgs e)
        {
            foreach (var item in QuizA.QuestionsAndCorrectAnswers)
            {
                if (item.Values.First() == label1.Text)
                {
                    if (btn1opt.Text == item.Keys.First())
                    {
                        btn1opt.BackColor = Color.Green;
                       // Thread.Sleep(1000);

                        MessageBox.Show("True");

                        quiz.ResultScore.Add(true);
                        break;
                    }
                    else
                    {
                        btn1opt.BackColor = Color.Red;
                       // Thread.Sleep(1000);
                        MessageBox.Show("False");

                        quiz.ResultScore.Add(false);
                        break;
                    }
                }
            }

            Next();

        }

        private void btn2opt_Click(object sender, EventArgs e)
        {

            foreach (var item in QuizA.QuestionsAndCorrectAnswers)
            {
                if (item.Values.ToString() == label1.Text)
                {
                    if (btn2opt.Text == item.Keys.ToString())
                    {
                        btn2opt.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn2opt.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next();
        }


        private void btn3opt_Click(object sender, EventArgs e)
        {
            foreach (var item in QuizA.QuestionsAndCorrectAnswers)
            {
                if (item.Values.First() == label1.Text)
                {
                    if (btn3opt.Text == item.Keys.First())
                    {
                        btn3opt.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn3opt.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next();
        }

        private void btn4opt_Click(object sender, EventArgs e)
        {
            foreach (var item in QuizA.QuestionsAndCorrectAnswers)
            {
                if (item.Values.ToString() == label1.Text)
                {
                    if (btn3opt.Text == item.Keys.ToString())
                    {
                        btn4opt.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn4opt.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next();
        }
    }
}
