using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PkmnSimulator
{

    public class Catching
    {
        Pokeball pokeballs = new Pokeball();
        PokemonDB pokemonDB = new PokemonDB();
        Random random = new Random();
        Utility util = new Utility();
        Boolean pokemonCaught = false;
        int startingHp;
        int count = 0;
       
       
        public void CatchAttempt(string username, int pokemonHp, string pokemonName, RadioButton pokeballChoice)
        {
            if (count == 0)
            {
                pokemonDB.initialisePokemon();
            } 


                var pokeball = pokeballChoice.Text;
        
            if (pokeballs.pokeballs.ContainsKey(pokeball))
            {
                var baseCatchRate = pokeballs.pokeballs[pokeball]; //get the catch rate of that pokeball
             //   MessageBox.Show(baseCatchRate.ToString());
                //MessageBox.Show("Current Hp: " + pokemonHp);


                //Check the users text file to see if pokeballs > 1
                //if pokeballs is greater than 1 then usePokeBall();
                //else MBox u dont have enough pokeballs for that 
                foreach (var poke in pokemonDB.pokemonList)
                {
                    if (poke.name == pokemonName)
                    {
                        startingHp = poke.hp;
                       // MessageBox.Show("Starting hp: " + startingHp);
                    }

                }
                // (HPmax * 255 * 4) / (HPcurrent * Ball),
                var catchNumber =(startingHp * 255 * 4) / (pokemonHp * baseCatchRate);
              //  MessageBox.Show(catchNumber.ToString());
                if(catchNumber > 100)
                {
                    int decideIfCaught = random.Next(1, 10); // creates a number between 1 and 12
                    if(decideIfCaught >= 5)
                    {
                        pokemonCaught = true;
                    }else
                    {
                        pokemonCaught = false;
                    }
                }
                if (pokemonCaught)
                {
                    MessageBox.Show("Pokemon caught!");
                
                    //Handle pokemon addition
                    //-1 from pokeballs
                    
                }
                else
                {
                    MessageBox.Show("Pokemon escapes!");
               
         
                    //-1 from pokeballs
                   
                }

                util.updateItemAmount(username, pokeballChoice.Text);

            }

            count++;

        }

      

        public Boolean checkIfUserHasHasPokeball(string username, RadioButton radioButton, int line)
        {
           // Boolean hasPokeballs = false;
            //check the text file
            //get the right line
            string pokeballType = radioButton.Text;
            
                string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";


                using (var file = new StreamReader(path))
                {
                    string pokeball = File.ReadLines(path).Skip(line).Take(1).First();
                    int pokeballCount = Int32.Parse(pokeball); //Make the string an int

                    if (pokeballCount > 0)
                    {
                        return true;
                    
                }
                    else
                    {
                        return false;
                }
            }
        }




    }
}
