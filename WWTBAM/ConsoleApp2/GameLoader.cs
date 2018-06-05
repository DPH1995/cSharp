using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class GameLoader
    {
        public void initGameQuestions()
        {
            Console.WriteLine("You are playing who wants to be a Millionaire!");
            Console.WriteLine("\n");
            QuestionAnswers questionAnswers = new QuestionAnswers();
            Questions questions = new Questions();
            questions.firstQuestion();
 
        }

        public void initInstructions()
        {
            Console.WriteLine("All inputs for question answers/options should be capitalised - Eg: A");
            Console.WriteLine("Start game? : Y/N");
            String optionSelected = Console.ReadLine();
            if(optionSelected == "Y")
            {
                initGameQuestions();
            }
        }

        public void exitGame()
        {

        }
    }
}
