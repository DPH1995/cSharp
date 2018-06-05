using System.Collections.Generic;
using System.Drawing;

namespace PkmnSimulator
{


    //https://pokemon-trainer.com/wiki/sprite-sun-moon-animated/
    class PokemonDB
    {
        public List<Pokemon> pokemonList = new List<Pokemon>();
        PokemonMoves pokemonMoves = new PokemonMoves();

        public  Dictionary<int, Image> idImage = new Dictionary<int, Image>();
        public void addPokemon(Pokemon pokemon, List<Pokemon> pokemonList)
        {
            pokemonList.Add(pokemon);
        }

        public void initialisePokemon()
        {

            Pokemon p001 = new Pokemon("Bulbasaur", 001, 5, 20, 500, pokemonMoves.bulbasaur, Properties.Resources.bulbasaur);
            Pokemon p004 = new Pokemon("Charmander", 004, 5, 20, 500, pokemonMoves.charmander, Properties.Resources.charmander);
            Pokemon p007 = new Pokemon("Squirtle", 007, 5, 20, 500, pokemonMoves.bulbasaur, Properties.Resources.squirtle);
            Pokemon p076 = new Pokemon("Golem", 076, 36, 180, 3600, pokemonMoves.bulbasaur, Properties.Resources.golem);
            Pokemon p142 = new Pokemon("Aerodactyl", 142, 45, 100, 4500, pokemonMoves.bulbasaur, Properties.Resources.aerodactyl);
            Pokemon p150 = new Pokemon("Mewtwo", 150, 70, 200, 70000, pokemonMoves.bulbasaur, Properties.Resources.mewtwo);

            pokemonList.Add(p001);
            pokemonList.Add(p004);
            pokemonList.Add(p007);
            idImage.Add(001, Properties.Resources.bulbasaur);
            idImage.Add(004, Properties.Resources.charmander);
            idImage.Add(007, Properties.Resources.squirtle);
            idImage.Add(076, Properties.Resources.golem);
            idImage.Add(142, Properties.Resources.aerodactyl);
            idImage.Add(150, Properties.Resources.mewtwo);

        }

        

    }
}


