using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PkmnSimulator
{
    public class Potions
    {
        public int newHp;
        public Dictionary<string, int> potions = new Dictionary<string, int>();
        public Potions()
        {
            potions.Add("Potion", 20);
            potions.Add("Super potion", 50);
        }

        public int usePotion(string potion, int currentHp)
        {
            int potionHealAmount = 0;
            var updateHp = 0;
            if (potions.ContainsKey(potion))
            {
                potionHealAmount = potions[potion];
                updateHp = currentHp + potionHealAmount;
               
                                                             //get the pokemons current hp
                                                             //apply the potionHealAmount to the currentHp

            }
            return updateHp;
        }

        public int DrinkPotion(string potionType, Pokemon pokemon, int pokemonsMaxHP)
        {
            if (potions.ContainsKey(potionType))
            {
                var healAmount = potions[potionType];
                newHp = pokemon.hp + healAmount;
                //gets the heal amount of the potion
                if(newHp > pokemonsMaxHP)
                {
                    newHp = pokemonsMaxHP; //Ensures the newHp (after potion) isnt > than the pokemons Max hp
                }
                return newHp;
               
            }
            return newHp;


        }

        public Boolean checkIfUserHasPotions(string username, string potion)
        {
            Boolean hasPotions = false; 
            //check the text file
            //get the right line

            if(potion == "Potion")
            {

                string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";


                using (var file = new StreamReader(path))
                {

                    string potions = File.ReadLines(path).Skip(13).Take(1).First();
                    // string potion = File.ReadLines(path).Skip(14).Take(1).First();
                    int potionCount = Int32.Parse(potions); //Make the string an int

                    if(potionCount > 0)
                    {
                        return true;
                    }else
                    {
                        return false;
                    }

                }
               
            }
            else if(potion == "Super potion")
            {
                string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";
                using (var file = new StreamReader(path))
                {
                    
                    string potions = File.ReadLines(path).Skip(14).Take(1).First();
                    int potionCount = Int32.Parse(potions); //Make the string an int

                    if (potionCount > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }

            return hasPotions;
        }

        

    }
}
