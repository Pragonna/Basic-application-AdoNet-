using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizzes.QuizForms;
using Quizzes.Quizzes.Questions;

namespace Quizzes.Quizzes
{
    public partial class QuizBPage : Form
    {
        private IQuizCreator quiz;
        private string question;
        private string[] answers;
        int countKey;
        int quizCount;
        private QuizB quizB;
        private ResultForm resultInfo;

        public QuizBPage()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void QuizBPage_Load_1(object sender, EventArgs e)
        {
            quizB = new QuizB();

            labelQuest.Text = string.Empty;
            quiz = new QuizCreatorB();
            countKey = 1;
            quizCount = 0;

            Next().GetAwaiter();
        }

        #region Methods

        private async Task Next()
        {
            if (!string.IsNullOrEmpty(labelQuest.Text))
                await Task.Delay(1000);

            ButtonColorClear();

            quiz.GenerateQuiz(out question, out answers);

            labelQuest.Text = question;
            labelKey.Text = countKey + ". ";

            var _answers = answers;

            if (string.IsNullOrEmpty(question) || answers is null)
                EndResult();
            else
            {
                btn1optl.Text = _answers[0];
                btn2optl.Text = _answers[1];
                btn3optl.Text = _answers[2];
                btn4optl.Text = _answers[3];

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

            MessageBox.Show(message, "Informasiya");

            Close();
        }

        private void ButtonColorClear()
        {
            btn1optl.BackColor = Color.White;
            btn2optl.BackColor = Color.White;
            btn3optl.BackColor = Color.White;
            btn4optl.BackColor = Color.White;
        }

        private void ButtonValueEmpty()
        {
            labelQuest.Text = string.Empty;
            btn1optl.Text = string.Empty;
            btn2optl.Text = string.Empty;
            btn3optl.Text = string.Empty;
            btn4optl.Text = string.Empty;
            labelKey.Text = string.Empty;
        }

        #endregion

        #region Events

        private void btn1optl_Click(object sender, EventArgs e)
        {
            foreach (var item in quizB.Questions)
            {
                if (item.Value == labelQuest.Text)
                {
                    if (btn1optl.Text == quizB.Answers[item.Key])
                    {
                        btn1optl.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn1optl.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }

            Next().GetAwaiter();
        }

        private void btn2optl_Click(object sender, EventArgs e)
        {
            foreach (var item in quizB.Questions)
            {
                if (item.Value == labelQuest.Text)
                {
                    if (btn2optl.Text == quizB.Answers[item.Key])
                    {
                        btn2optl.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn2optl.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next().GetAwaiter();
        }

        private void btn3optl_Click(object sender, EventArgs e)
        {
            foreach (var item in quizB.Questions)
            {
                if (item.Value == labelQuest.Text)
                {
                    if (btn3optl.Text == quizB.Answers[item.Key])
                    {
                        btn3optl.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn3optl.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next().GetAwaiter();
        }

        private void btn4optl_Click(object sender, EventArgs e)
        {
            foreach (var item in quizB.Questions)
            {
                if (item.Value == labelQuest.Text)
                {
                    if (btn4optl.Text == quizB.Answers[item.Key])
                    {
                        btn4optl.BackColor = Color.Green;
                        quiz.ResultScore.Add(true);
                    }
                    else
                    {
                        btn4optl.BackColor = Color.Red;
                        quiz.ResultScore.Add(false);
                    }
                }
            }
            Next().GetAwaiter();
        }

        #endregion
    }
}
