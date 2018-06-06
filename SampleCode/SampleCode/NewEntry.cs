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

namespace SampleCode
{
    public partial class NewEntry : Form
    {
        public NewEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               
                String fileName = textBox1.Text;
                fileName = fileName.Replace(" ", "_");
                File.WriteAllText(fileName, textBox3.Text);
                MessageBox.Show("Sample Code saved! as " + fileName + ".txt");
                // Process.Start("notepad.exe", fileName);
                File.AppendAllText("library2.txt", fileName + Environment.NewLine);
            } else
            {
                MessageBox.Show("You must enter a title!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        
    }


}
