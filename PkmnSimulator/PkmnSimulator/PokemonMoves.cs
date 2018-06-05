using System.Collections.Generic;

namespace PkmnSimulator
{
    public class PokemonMoves
    {

        public Dictionary<string, int> moveDmg = new Dictionary<string, int>();


        public PokemonMoves()
        {
     
            moveDmg.Add("Scratch", 10);
            moveDmg.Add("Tail whip", 0);
            moveDmg.Add("Growl", 0);
            moveDmg.Add("Vine whip", 20);
            moveDmg.Add("Tackle", 10);
            moveDmg.Add("Ember", 20);


        }

        public string[] bulbasaur = { "Scratch", "Tail whip", "Growl", "Vine whip" };
        public string[] charmander = { "Tackle", "Tail whip", "Growl", "Ember" };

        

    }
}
