using System.Collections.Generic;
using System.Windows.Forms;

namespace PkmnSimulator
{
    public class Pokeball
    {

        public Dictionary<string, int> pokeballs = new Dictionary<string, int>();
        string[] pokeballsArray = { "PokeBall", "GreatBall", "UltraBall", "MasterBall" };
        PokemonDB pokemonDB = new PokemonDB();
     



        public Pokeball()
        {
            pokeballs.Add("PokeBall", 17);
            pokeballs.Add("GreatBall",25);
            pokeballs.Add("UltraBall",35);
            pokeballs.Add("MasterBall", 100);
            
        }

       
        
        

    }
}
