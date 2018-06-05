using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        private static GameLoader gameLoader = new GameLoader();
        private static Boolean hasSelected = false;
    
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to who wants to be a Millionaire!");
            startGame();
            Console.ReadKey();

        }

        public static void startGame()
        {
      
            Console.WriteLine("Select an option: 1 (Play) / 2 (Instructions) / 3 (Exit) ");

            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("You selected option 1, play!");
                    hasSelected = true;
                    gameLoader.initGameQuestions();
                    break;
                case 2:
                    Console.WriteLine("You selected option 2, Options!");
                    hasSelected = true;
                    gameLoader.initInstructions();
                    break;
                case 3:
                    Console.WriteLine("You selected option 3, Exit!");
                    hasSelected = true;
                    gameLoader.exitGame();
                    break;
                default:
                    Console.WriteLine("Invalid option, enter an number between 1-3");
                    hasSelected = false;
                    break;
            }
            if(hasSelected == false)
            {
                startGame();
            }

        }

    
    }

}
