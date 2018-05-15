using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWTBAM
{
    class Questions
    {
        private string question;
        private string[] answers;
        private string correctAnswer;
        private int questionNumber;


        public Questions(string question, string[] answers, string correctAnswer, int questionNumber)
        {
            this.question = question;
            this.answers = answers;
            this.correctAnswer = correctAnswer;
            this.questionNumber = questionNumber;
        }

        public Questions()
        {

        }

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public string[] Answers
        {
            get
            {
                return answers;
            }

            set
            {
                answers = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }

            set
            {
                correctAnswer = value;
            }
        }

        public int QuestionNumber
        {
            get
            {
                return questionNumber;
            }

            set
            {
                questionNumber = value;
            }
        }

   


    }
}
