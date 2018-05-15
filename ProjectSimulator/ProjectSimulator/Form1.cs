using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = usernameTxt.Text;
            String password = passwordTxt.Text;

            if(username == "Daniel" && password == "dph")
            {
             
                System.Windows.Forms.MessageBox.Show("Logged in successfully");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
               

            } else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
