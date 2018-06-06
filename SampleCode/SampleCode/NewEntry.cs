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
        Font notePadFont = new Font("Consolas", 11.0f);
        public NewEntry()
        {
            InitializeComponent();
            initializeFonts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
               
                textBox1.Font = notePadFont;
                String fileName = textBox1.Text;
                File.WriteAllText(fileName, textBox3.Text);
                MessageBox.Show("Sample Code saved! as " + fileName + ".txt");
               
                File.AppendAllText("library.txt", fileName + Environment.NewLine);
            } else
            {
                MessageBox.Show("You must enter a title!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "/*      */";
        }

        private void initializeFonts()
        {
            textBox1.Font = notePadFont;
            textBox2.Font = notePadFont;
            textBox3.Font = notePadFont;
            textBox3.Text = "/*      */";
        }
    }


}
