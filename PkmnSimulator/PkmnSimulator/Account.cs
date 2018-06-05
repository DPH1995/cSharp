using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmnSimulator
{
    class Account
    {
        public string username;
        public string password;
        public int money;
        public int fights;
        public int wins;
        public int catches;
        public int losses;
        public int winPercentage;
        public int pokedexCompletion;
        public int pokeballs;
        public int greatballs;
        public int ultraballs;
        public int masterballs;
        public int potions;
        public int superpotions;
        public Boolean hasStarter;

        public Account(string username, string password, int money, int fights, int wins, int catches, int losses, int winPercentage, int pokedexCompletion, int pokeballs, int greatballs, int ultraballs, int masterballs, int potions, int superpotions, Boolean hasStarter)
        {
            this.username = username;
            this.password = password;
            this.money = money;
            this.fights = fights;
            this.wins = wins;
            this.catches = catches;
            this.losses = losses;
            this.winPercentage = winPercentage;
            this.pokedexCompletion = pokedexCompletion;
            this.pokeballs = pokeballs;
            this.greatballs = greatballs;
            this.ultraballs = ultraballs;
            this.masterballs = masterballs;
            this.potions = potions;
            this.superpotions = superpotions;
            this.hasStarter = hasStarter;
        }
    }
}
