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
    public partial class ViewEntryForm : Form
    {
        public Object selectedSample;
        public string selected;
        Font notePadFont = new Font("Consolas", 11.0f);
        Font notePadFont2 = new Font("Consolas", 8.0f);
        
        
        List<string> fileNameList = new List<string>();
        public ViewEntryForm()
        {
            InitializeComponent();
            listBox1.Font = notePadFont2;
            populateList();
           
        }

        private void ViewEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void populateList()
        {
            string[] fileNames = File.ReadAllLines("library.txt");
            foreach(var str in fileNames)
            {
                fileNameList.Add(str);
            }
            listBox1.DataSource = fileNameList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedSample = listBox1.SelectedItem;
            selected = selectedSample.ToString();

            textBox1.Text = "";
           
            textBox1.Font = notePadFont;
            textBox1.Text = File.ReadAllText(selected);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("notepad.exe", selected);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
