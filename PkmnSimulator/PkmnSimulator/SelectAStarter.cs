using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PkmnSimulator
{
    public partial class SelectAStarter : Form

    {

        private Boolean starterSelected = false;
        private int starterID = 0;
        private string name = "";
        private string user;
        PokemonMoves pokemonMoves = new PokemonMoves();
        public SelectAStarter(string username)
        {
            InitializeComponent();
            user = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Bulbasaur
            name = "Bulbasaur";
            starterSelected = true;
            starterID = 001;
            Pokemon bulbasaur = new Pokemon("Bulbasaur", starterID, 5, 20, 500, pokemonMoves.bulbasaur, Properties.Resources.squirtle);
          
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Charmander
            name = "Charmander";
            starterSelected = true;
            starterID = 004;
        

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Squirtle
            name = "Squirtle";
            starterSelected = true;
            starterID = 007;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (starterSelected && starterID != 0)
            {
                string path = @"C:\Users\Me\Desktop\sim\" + user + "-Pokemon.txt";
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(starterID);
                    tw.Close();

                }

                MessageBox.Show(name + " Selected - Great choice!");
                setStarterToTrue(user);
                MenuForm menu = new MenuForm(user);
                this.Hide();
              
                menu.ShowDialog();
              
               

            }
            
            else
            {
                MessageBox.Show("You need to select a starter!");
            }

        }

        private void SelectAStarter_Load(object sender, EventArgs e)
        {

        }

        private void setStarterToTrue(String user)
        {
          
            string patha = @"C:\Users\Me\Desktop\sim\" + user + ".txt";
            string booleanToChange = File.ReadAllText(patha); booleanToChange = booleanToChange.Replace("False", "True"); File.WriteAllText(patha, booleanToChange);

        }



    }
}
