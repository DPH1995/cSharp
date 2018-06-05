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
    public partial class CreateAccountForm : Form
    {

        
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.ToString();
            string password = passwordTxt.Text.ToString();
            
            CreateAccount(username, password);
        }

        private void CreateAccount(string username, string password)
        {
            var newAccount = new Account(username, password, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, false);
            string path = @"C:\Users\Me\Desktop\sim\"+username+".txt";
            using(var tw = new StreamWriter(path, true))
            {
                tw.WriteLine(newAccount.username);
                tw.WriteLine(newAccount.password);
                tw.WriteLine(newAccount.money);
                tw.WriteLine(newAccount.fights);
                tw.WriteLine(newAccount.wins);
                tw.WriteLine(newAccount.catches);
                tw.WriteLine(newAccount.losses);
                tw.WriteLine(newAccount.winPercentage);
                tw.WriteLine(newAccount.pokedexCompletion);
                tw.WriteLine(newAccount.pokeballs);
                tw.WriteLine(newAccount.greatballs);
                tw.WriteLine(newAccount.ultraballs);
                tw.WriteLine(newAccount.masterballs);
                tw.WriteLine(newAccount.potions);
                tw.WriteLine(newAccount.superpotions);
                tw.WriteLine(newAccount.hasStarter);
                tw.Close();    
            }

           
            MessageBox.Show("Account created!");
            this.Close();
        }
    }
}
