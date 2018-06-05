using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class LifeLines
    {

        private string name;
        private string description;
        private Boolean hasBeenUsed;
        private string correctAnswer;
   


        public LifeLines(string name, string description, bool hasBeenUsed)
        {
            this.name = name;
            this.description = description;
            this.hasBeenUsed = hasBeenUsed;
        }

        public LifeLines()
        {

        }

        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public bool HasBeenUsed { get => hasBeenUsed; set => hasBeenUsed = value; }


 

        public void lifeLineFunctionality(LifeLines lifeline, Questions question, int number)
        {
            int answerIndex;

           
            if (lifeline.name == "fiftyfifty" && lifeline.hasBeenUsed != true)
            {


                string answer = question.CorrectAnswer;
                if (answer == "A")
                {
                    answerIndex = 0;
                    correctAnswer = question.Answers[answerIndex];
                }
                else if (answer == "B")
                {
                    answerIndex = 1;
                    correctAnswer = question.Answers[answerIndex];
                }
                else if (answer == "C")
                {
                    answerIndex = 2;
                    correctAnswer = question.Answers[answerIndex];
                }
                else if (answer == "D")
                {
                    answerIndex = 3;
                    correctAnswer = question.Answers[answerIndex];
                }
            //    Console.WriteLine(lifeline.description);

                Console.WriteLine(correctAnswer);
                randomAnswers(question.Answers, correctAnswer);

          
                lifeline.hasBeenUsed = true;
                
            }
            else if (lifeline.name == "Phone a friend" && lifeline.hasBeenUsed != true)
            {
               // Console.WriteLine(lifeline.description);
                Console.WriteLine("\nYou call your friend and they are adamant the answer is: " + question.CorrectAnswer);
                Console.WriteLine("Enter your answer: ");
                lifeline.hasBeenUsed = true;
            }

            else if(lifeline.name == "Ask the audience" && lifeline.hasBeenUsed != true)
            {
                //Console.WriteLine(lifeline.description);
                Console.WriteLine("The audience are swaying towards answer: " + question.CorrectAnswer + " With 74%");
                lifeline.hasBeenUsed = true;
            }
           else if (lifeline.hasBeenUsed)
            {
                Console.WriteLine("This lifeline has already been used, enter your answer: ");
            }
        }


        public void randomAnswers(String[] answersArray, string correctAnswer)
        {
        
            //has a bug when correct answer is D
                for (int i = 0; i < answersArray.Length; i++)
                {
                    if (answersArray[i] != correctAnswer)
                    {
                        Console.WriteLine(answersArray[i]); 
                    }
                }
            
        }


    }

   

    

}
