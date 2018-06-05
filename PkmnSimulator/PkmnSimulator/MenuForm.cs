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
    public partial class MenuForm : Form
    {
        PokemonDB pokemonDatabase = new PokemonDB();
        public string loggedin;
       
        public MenuForm(String username)
        {
            pokemonDatabase.initialisePokemon();
            InitializeComponent();
            loadAccountSettings(username);
            loadPokemonParty(username, pokemonDatabase.pokemonList);
            loggedin = username;
          
        }

        public MenuForm()
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void loadAccountSettings(String username)
        {
            string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";
            string pokemonFile = @"C:\Users\Me\Desktop\sim\" + username + "-Pokemon.txt";

            using (var file = new StreamReader(path)) { 

            string money = File.ReadLines(path).Skip(2).Take(1).First();
            string fights = File.ReadLines(path).Skip(3).Take(1).First();
            string wins = File.ReadLines(path).Skip(4).Take(1).First();
            string catches = File.ReadLines(path).Skip(5).Take(1).First();
            string losses = File.ReadLines(path).Skip(6).Take(1).First();
            string winPercentage = File.ReadLines(path).Skip(7).Take(1).First();
            string hasStarter = File.ReadLines(path).Skip(15).Take(1).First();

            usernameLabel.Text = "Name: " + username;
            moneyLabel.Text = "Money: " + money;
            fightsLabel.Text = "Fights: " + fights;
            winsLabel.Text = "Wins: " + wins;
            catchesLabel.Text = "Catches: " + catches;
            lossesLabel.Text = "Losses/Flees: " + losses;
            winPercentageLabel.Text = "Win %: " + winPercentage;
          

             //   int amount = getPokedex(username);
             //   string number = amount.ToString();
            //    pokedexLabel.Text = "PokeDex completion: " +number + " of 386";

                if (hasStarter == "False")
                {
                    MessageBox.Show("Welcome! Select a starter pokemon to get started!");
                    file.Close(); //this one fixed issue
                    var StarterSelection = new SelectAStarter(username);
                    StarterSelection.ShowDialog();
                }else
                {
                  //  MessageBox.Show("Must be true!");
                }
                    
                }

                
        }
            
           

        public int getPokedex(string username)
        {
            string pokemonFile = @"C:\Users\Me\Desktop\sim\" + username + "-Pokemon.txt";
            int lines = File.ReadAllLines(pokemonFile).Length;
            return lines;
        }

        public void loadPokemonParty(string username, List<Pokemon> pokemonList)
        {
            

            string pokemonFile = @"C:\Users\Me\Desktop\sim\" + username + "-Pokemon.txt";
            string[] ids = File.ReadAllLines(pokemonFile);
            int[] idsInts = Array.ConvertAll(ids, int.Parse);
            //has a list of pokemon, has an array of ids
            List<int> matchesList = new List<int>();


           
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
         
            //List<PictureBox> pictureboxList = new List<PictureBox>();

            //pictureboxList.Add(pictureBox1);
            //pictureboxList.Add(pictureBox2);
            //pictureboxList.Add(pictureBox3);

        }

       
       
        private void partyButton_Click(object sender, EventArgs e)
        {
            var party = new PartyForm();
            party.ShowDialog();
        }

        private void wildBattleButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Logged in user is: " + loggedin);
            WildBattleForm wildbattleform = new WildBattleForm(loggedin);
            wildbattleform.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
