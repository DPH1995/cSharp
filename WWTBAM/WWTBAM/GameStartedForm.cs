using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWTBAM
{
    public partial class GameStartedForm : Form
    {
        public GameStartedForm()
        {
            InitializeComponent();
            getFirstQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void getFirstQuestion()
        {
            QuestionAnswers answers = new QuestionAnswers();
            Questions questionOne = new Questions("Who is the current US president?", answers.question1, "B", 1);
           // answersLabel.Text = questionOne.Question;
            questionLabel.Text = questionOne.Question;
            questionNumberLabel.Text = "Question: " + questionOne.QuestionNumber + "/15";
            answersLabel.Text = answers.question1[0] + "\n" +  answers.question1[1] + "\n" + answers.question1[2] + "\n" + answers.question1[3];

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
