using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkmnSimulator
{

    public partial class WildBattleForm : Form
        
    {
        Catching catching = new Catching();
        PokemonPartyUtility partyUtility = new PokemonPartyUtility();
        PokemonDB pokemonDatabase = new PokemonDB();
        PokemonMoves pokemonMoves = new PokemonMoves();
        Random random = new Random();
        Potions potions = new Potions();
        Pokemon pokemonBeingUsed;
        Pokemon wildPokemon;
        Utility util = new Utility();
        Pokeball pokeball = new Pokeball();

        public static PictureBox pictureBox;
        private static string usernamed;
        private int startingHp;
        private int count = 0;
        private int chp;
        private int userStartingHp;
        private int updatedHp;
        private int wildPokemonId;
        private int wildPokemonCurrentHp;
        


        public WildBattleForm(String username)
        {
            usernamed = username;
          
          
            InitializeComponent();
         
            pokemonDatabase.initialisePokemon();
            loadPokemonParty(username, pokemonDatabase.pokemonList);
            loadFirstPokemon(pictureBox1, pictureBox8);
            wildPokemonId = getRandomPokemon(pokemonDatabase.pokemonList);
            loadWildPokemon(wildPokemonId, pictureBox7);
            updatedHp = pokemonBeingUsed.hp;
           
        }

       

        public void loadFirstPokemon(PictureBox pictureParty, PictureBox pictureFighter)
        {
            Image theSprite = pictureParty.Image;
            pictureFighter.Image = theSprite;

            if (pokemonDatabase.idImage.ContainsValue(theSprite))
            {
                var pokemonID = pokemonDatabase.idImage.FirstOrDefault(pokemon => pokemon.Value == theSprite).Key; //get the key(id) of the pokemon where the value = thesprite
                getPokemonStats(pokemonID);
            }

        }

       public void getPokemonStats(int pokemonID)
        {
            var poke = pokemonDatabase.pokemonList.Find(pokemon => pokemon.id == pokemonID);

            var level = poke.level.ToString();
            var hp = poke.hp.ToString();
            int currentHp = Int32.Parse(hp);
            label4.Text = poke.name;
            label5.Text = "Lv: " + level;
            label6.Text = "Hp: " + currentHp + "/" + hp;
            pokemonBeingUsed = poke;
            loadPokemonMoves(poke);
            userStartingHp = pokemonBeingUsed.hp;
        }

        public void loadPokemonMoves(Pokemon pokemon)
        {
            radioButton1.Text = pokemon.Moves[0];
            radioButton2.Text = pokemon.Moves[1];
            radioButton3.Text = pokemon.Moves[2];
            radioButton4.Text = pokemon.Moves[3];

        }

        public int getRandomPokemon(List<Pokemon> pokemonList) //Get a random Id (int) from the pokemon List. 
        {
            int randomID = random.Next(pokemonList.Count);
            randomID++;
            return randomID;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(usernamed);
        }

        public void loadWildPokemon(int wildPokemonID, PictureBox pictureBox)
        {
            //Search the dictionary for the id, get the sprite. Set the sprite to the picturebox.
            if (pokemonDatabase.idImage.ContainsKey(001)) //wildPokemonID
            {
           //     pictureBox.Image = pokemonDatabase.idImage[wildPokemonID];
                pictureBox.Image = pokemonDatabase.idImage[001];

                //Load wild pokemons stats
                var poke = pokemonDatabase.pokemonList.Find(pokemon => pokemon.id == 001);
               
                var level = poke.level.ToString();
                var hp = poke.hp.ToString();
                var currentHp = hp;
                label1.Text = poke.name;
                label2.Text = "Lv: " + level;
                label3.Text = "Hp: " + currentHp + "/" +hp;
                wildPokemon = poke;
                startingHp = wildPokemon.hp;
                wildPokemonCurrentHp = startingHp;
            }
        }
        
        public void loadPokemonParty(string username, List<Pokemon> pokemonList)
        {
            string pokemonFile = @"C:\Users\Me\Desktop\sim\" + username + "-Pokemon.txt";
            string[] ids = File.ReadAllLines(pokemonFile);
            int[] idsInts = Array.ConvertAll(ids, int.Parse);
            //has a list of pokemon, has an array of ids
            
            PictureBox[] pictureboxes = new PictureBox[6]; //array of pictureboxes for party!
            {
                pictureboxes[0] = pictureBox1;
                pictureboxes[1] = pictureBox2;
                pictureboxes[2] = pictureBox3;
                pictureboxes[3] = pictureBox4;
                pictureboxes[4] = pictureBox5;
                pictureboxes[5] = pictureBox6;

                for (int i = 0; i < idsInts.Length; i++)

                    if (pokemonDatabase.idImage.ContainsKey(idsInts[i]))
                    {
                        pictureboxes[i].Image = pokemonDatabase.idImage[idsInts[i]];

                    }
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }


        public void DamageEnemy(Label label, RadioButton radioButton)
        {
            if (radioButton.Checked == true)
            {
                
                if (pokemonMoves.moveDmg.ContainsKey(radioButton.Text))
                {
                    var damage = pokemonMoves.moveDmg[radioButton.Text];

                    if (count == 0)
                    {
                        chp = startingHp - damage;
                        label3.Text = "Hp : " + chp.ToString() + "/" + startingHp;
                        count++;
                    }
                    else
                    {
                        chp = chp - damage;
                        label3.Text = "Hp : " + chp.ToString() + "/" + startingHp;
                        count++;

                    }
                   
                    textBox1.AppendText(pokemonBeingUsed.name + " used " + radioButton.Text + " and did " + damage + " damage.\n");
                    if (chp <= 0)
                    {
                        //Pokemon is dead
                        textBox1.AppendText(wildPokemon.name + " fainted!");
                        endBattle();
                    }
                }

                wildPokemonCurrentHp = chp;

            }
        }
       
        public void EnemyAttack(Label label, Pokemon wildPokemon)
        {
            if (wildPokemon.hp > 0) {
                //get a random move from the wildPokemons array
                //get the damage from that move.
                //apply the damage to the users pokemon

                var randomMove = random.Next(0, wildPokemon.Moves.Length); //get a random move from the pokemon move array
                string move = wildPokemon.Moves[randomMove];
                if (pokemonMoves.moveDmg.ContainsKey(move))
                {
                    var damage = pokemonMoves.moveDmg[move]; //get the value of the random move  (damage)
                    pokemonBeingUsed.hp = pokemonBeingUsed.hp - damage;
                    label.Text = "Hp : " + pokemonBeingUsed.hp.ToString() + "/" + userStartingHp;
                    textBox1.AppendText(wildPokemon.name + " used " + move + " and did " + damage + " damage!\n");
                    if (pokemonBeingUsed.hp <= 0)
                    {
                        //Pokemon is dead
                        textBox1.AppendText(pokemonBeingUsed.name + " fainted!");
                        endBattle();
                    }
                }
            }
        }

        private void endBattle()
        {
            button1.Hide();
           // this.Close();
        }
       
            private void button1_Click(object sender, EventArgs e)
            {
            
            if (radioButton1.Checked == true)
            {
                DamageEnemy(label3, radioButton1);
                EnemyAttack(label6, wildPokemon);
            }
            else if (radioButton2.Checked == true)
            {
                DamageEnemy(label3, radioButton2);
                EnemyAttack(label6, wildPokemon);
            }
            else if (radioButton3.Checked == true)
            {
                DamageEnemy(label3, radioButton3);
                EnemyAttack(label6, wildPokemon);
            }
            else if (radioButton4.Checked == true)
            {
                DamageEnemy(label3, radioButton4);
                EnemyAttack(label6, wildPokemon);
            }

            }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if(radioButton6.Checked == true)
            {
                Boolean userHasPokeballs = catching.checkIfUserHasHasPokeball(usernamed, radioButton6, 9);
                if (userHasPokeballs)
                {
                    catching.CatchAttempt(usernamed, wildPokemonCurrentHp, wildPokemon.name, radioButton6);
                }
                else
                {
                    MessageBox.Show("You dont have enough " + radioButton6.Text + " for this!");
                }
            }
            else if(radioButton7.Checked == true)
            {
                Boolean userHasPokeballs = catching.checkIfUserHasHasPokeball(usernamed, radioButton7, 10);
                if (userHasPokeballs)
                {
                    catching.CatchAttempt(usernamed, wildPokemonCurrentHp, wildPokemon.name, radioButton7);
                }
                else
                {
                    MessageBox.Show("You dont have enough " + radioButton7.Text + " for this!");
                }
            }
            else if (radioButton8.Checked == true)
            {
                Boolean userHasPokeballs = catching.checkIfUserHasHasPokeball(usernamed, radioButton8, 11);
                if (userHasPokeballs)
                {
                    catching.CatchAttempt(usernamed, wildPokemonCurrentHp, wildPokemon.name, radioButton8);
                }
                else
                {
                    MessageBox.Show("You dont have enough " + radioButton8.Text + " for this!");
                }
            }
            else if (radioButton9.Checked == true)
            {
               // catching.CatchAttempt(wildPokemon, radioButton9);
            }
            else if(radioButton10.Checked == true)
            {
                //TODO find another way to manage the current pokemons HP
                int currentHpOfUsedPokemon = getPokemonsCurrentHP(pokemonBeingUsed); //the pokemons current hp
                pokemonBeingUsed.hp = currentHpOfUsedPokemon;
                Boolean potionResult = potions.checkIfUserHasPotions(usernamed, "Potion");
                if (potionResult) //if user has potions
                {
                    var updatedHp = potions.DrinkPotion("Potion", pokemonBeingUsed, userStartingHp);
                    pokemonBeingUsed.hp = updatedHp;
                    label6.Text = "Hp : " + pokemonBeingUsed.hp.ToString() + "/" + userStartingHp;
                    //-1 from the file.
                   util.updateItemAmount(usernamed, "Potion");
                    
                }

                else
                {
                    MessageBox.Show("You do not have enough of this item!");
                }
            }
            else if (radioButton11.Checked == true)
            {
                Boolean potionResult = potions.checkIfUserHasPotions(usernamed, "Super potion");
                if (potionResult)
                {

                    var updatedHp = potions.DrinkPotion("Super potion", pokemonBeingUsed, userStartingHp);
                    pokemonBeingUsed.hp = updatedHp;
                    label6.Text = "Hp : " + pokemonBeingUsed.hp.ToString() + "/" + userStartingHp;
                    util.updateItemAmount(usernamed, "Super potion");
                 
                }
                else
                {
                    MessageBox.Show("You do not have enough of this item!");
                }
            }
            

        }
        public int getPokemonsCurrentHP(Pokemon pokemon)
        {
            return pokemon.hp;
        }

      

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You escaped!");
            this.Close();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
