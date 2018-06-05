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
    public partial class LoginForm : Form
    {
       
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.ToString();
            string password = passwordTxt.Text.ToString();
           
           
            string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";
            using (var file = new StreamReader(path))
            {

                string passwordLine = File.ReadLines(path).Skip(1).Take(1).First(); //skips the first line and takes the second line. 

                if (passwordLine == password)
                {
                    file.Close();
                    var menuform = new MenuForm(username);
                    menuform.Show();
                  

                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                }

            }
      
            Console.ReadLine();
            
        }

        
        

    }
}
