using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzes.QuizForms
{
    public partial class ResultForm : Form
    {
        private static List<string> info=new();

        public ResultForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            listBox.Items.Clear();
           
            foreach (var i in info)
                listBox.Items.Add(i);


        }

        public static string ResultInfo { set => info.Add(value); }


    }
}
