using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Questions
    {
        private string question;
        private string correctAnswer;
        private String[] answers;
        private int questionNumber;
       // public Questions[] questionList;
        QuestionAnswers questionAnswers = new QuestionAnswers();
        LifeLines ll = new LifeLines();
        LifeLines fiftyfifty = new LifeLines("fiftyfifty", "Removes two incorrect answers", false);
        LifeLines phoneAFriend = new LifeLines("Phone a friend", "Phone a friend to get help", false);
        LifeLines askTheAudience = new LifeLines("Ask the audience", "The audience will help answer the question", false);
        private List<LifeLines> lifeliness = new List<LifeLines>();
        


        public Questions(string question, string correctAnswer, string[] answers, int questionNumber)
        {
            this.question = question;
            this.correctAnswer = correctAnswer;
            this.answers = answers;
            this.questionNumber = questionNumber;
        }

        public Questions()
        {

        }

        public string Question { get => question; set => question = value; }
        public string CorrectAnswer { get => correctAnswer; set => correctAnswer = value; }
        public string[] Answers { get => answers; set => answers = value; }
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }

        public int correctAnswers = 0;
       
        
    
        public void firstQuestion()
        {
            Questions questions = new Questions();
            Console.WriteLine("Question 1/15    For £100");
            Questions question1 = new Questions("Who is the president of the United States?", "B", questionAnswers.question1, 1);
            questions.printQuestion(question1);
        }



        public void printQuestion(Questions question)
        {
            Console.WriteLine(question.question);
            Console.WriteLine("Is the answer - " + question.answers[0] + " " + question.answers[1] + " " + question.answers[2] + " " + question.answers[3]);
            lifelinePrompt();
            listenForLifeline(question);
            checkAnswer(question);
  
        }

        public void checkAnswer(Questions question)
        {
            String answer = Console.ReadLine();
            if (answer == question.correctAnswer)
            {
                Console.WriteLine("Answer is correct! Moving on to the next question");
                correctAnswers++;
                nextQuestion(correctAnswers);
            }
            else
            {
                Console.WriteLine("Answer is incorrect! \nGame Over");
            }
        }

        public void nextQuestion(int correctAnswers)
        {
            if (correctAnswers == 1)
            {
                Console.WriteLine("Question 2/15    For £200");
                Questions question2 = new Questions("Which of the following is not a car dealer", "B", questionAnswers.question2, 2);
                printQuestion(question2);

            }
            else if(correctAnswers == 2)
            {
                Console.WriteLine("Question 3/15    For £300");
                Questions question3 = new Questions("What was the name of Henry the Eigth's third wife?", "C", questionAnswers.question3, 3);
                printQuestion(question3);
            }
        

            else if(correctAnswers == 3)
                {
                    Console.WriteLine("Question 4/15    For £500");
                    Questions question4 = new Questions("Who won the british premier league in 2017?", "A", questionAnswers.question4, 4);
                    printQuestion(question4);
                }

            else if (correctAnswers == 4)
            {
                Console.WriteLine("Question 5/15    For £1000");
                Questions question5 = new Questions("Which of these is not a games console?", "B", questionAnswers.question5, 5);
                printQuestion(question5);
            }

            else if (correctAnswers == 5)
            {
                Console.WriteLine("Question 6/15    For £2000");
                Questions question6 = new Questions("Which of the following is not a song by artist Eminem?", "D", questionAnswers.question6, 6);
                printQuestion(question6);
            }

            else if (correctAnswers == 6)
            {
                Console.WriteLine("Question 7/15    For £4000");
                Questions question7 = new Questions("What is the largest land animal?", "B", questionAnswers.question7, 7);
                printQuestion(question7);
            }

            else if (correctAnswers == 7)
            {
                Console.WriteLine("Question 8/15    For £8000");
                Questions question8 = new Questions("Who is the lead male actor in Dear John?", "D", questionAnswers.question8, 8);
                printQuestion(question8);
            }

            else if (correctAnswers == 8)
            {
                Console.WriteLine("Question 9/15    For £16000");
                Questions question9 = new Questions("What year was Facebook created?", "A", questionAnswers.question9, 9);
                printQuestion(question9);
            }

            else if (correctAnswers == 9)
            {
                Console.WriteLine("Question 10/15    For £32000");
                Questions question10 = new Questions("Which of the following is not a Pokemon?", "C", questionAnswers.question10, 10);
                printQuestion(question10);
            }

            else if (correctAnswers == 10)
            {
                Console.WriteLine("Question 11/15    For £64000");
                Questions question11 = new Questions("How old was King George IV at his death?", "C", questionAnswers.question11, 11);
                printQuestion(question11);
            }

            else if (correctAnswers == 11)
            {
                Console.WriteLine("Question 12/15    For £125000");
                Questions question12 = new Questions("Where is the sport of hurling tradionally played?", "D", questionAnswers.question12, 12);
                printQuestion(question12);
            }

            else if (correctAnswers == 12)
            {
                Console.WriteLine("Question 13/15    For £250000");
                Questions question13 = new Questions("Which of the following is not a character in the TV series: Suits?", "B", questionAnswers.question13, 13);
                printQuestion(question13);
            }

            else if (correctAnswers == 13)
            {
                Console.WriteLine("Question 14/15    For £500000");
                Questions question14 = new Questions("Who holds the most titles for mens bodybuilding Mr Olympia?", "A", questionAnswers.question14, 14);
                printQuestion(question14);
            }

            else if (correctAnswers == 14)
            {
                Console.WriteLine("Question 15/15    For £1000000");
                Questions question15 = new Questions("Which of the following was not a labour of Hercules ?", "A", questionAnswers.question15, 15);
                printQuestion(question15);
            }
            else if( correctAnswers == 15)
            {
                Console.WriteLine("\nCongrations!!! You have beaten the game and won £1,000,000");
            }

        }

        

        public void lifelinePrompt()
        {
            Console.WriteLine("Use a lifeline? Y/N");

        }

        public void listenForLifeline(Questions question)
        {
            int questionSelected = question.questionNumber;
            String lifeline = Console.ReadLine();
            if(lifeline == "Y"){
              
                Console.WriteLine("Which lifeline do you want to use? 1 (50/50) / 2 (Phone a friend)  / 3 (Ask the audience) ");
                int lifelineChoice = int.Parse(Console.ReadLine());
             

                switch (lifelineChoice)
                {
                    case 1:
                        ll.lifeLineFunctionality(fiftyfifty, question, questionSelected);
                        break;
                    case 2:
                        ll.lifeLineFunctionality(phoneAFriend, question, questionSelected);
                        break;
                    case 3:
                        ll.lifeLineFunctionality(askTheAudience, question, questionSelected);
                        break;

                }

            }
            else
            {
                Console.WriteLine("Enter your answer: ");
            }
        }
      


        



    }






}
