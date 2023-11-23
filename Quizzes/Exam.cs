using Quizzes.QuizForms;
using Quizzes.Quizzes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzes
{
    public partial class Exam : Form
    {
        private QuizAPage A_PAGE;
        private QuizBPage B_PAGE;
        private ResultForm R_PAGE;

        public Exam()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void Exam_Load(object sender, EventArgs e)
        {
            A_PAGE = new QuizAPage();
            B_PAGE = new QuizBPage();
            R_PAGE = new ResultForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A_PAGE.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B_PAGE.ShowDialog();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            R_PAGE.ShowDialog();
        }
    }
}
