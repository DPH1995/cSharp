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
        public string sselectedLanguage;
        Font notePadFont = new Font("Consolas", 11.0f);
        Font notePadFont2 = new Font("Consolas", 8.0f);
       
        
     
        List<string> languageList = new List<string>();
        public ViewEntryForm()
        {

            InitializeComponent();
            var selectedLanguage = comboBox1.SelectedItem;
            listBox1.Font = notePadFont2;
            populateComboBox();
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
           
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var newSelected = comboBox1.SelectedItem;
            populateComboBox();
        }

        private void ViewEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void populateList()
        {
            List<string> fileNameList = new List<string>();
            string[] fileNames = File.ReadAllLines(sselectedLanguage + ".txt");
            foreach(var str in fileNames)
            {
                fileNameList.Add(str);
            }
            listBox1.DataSource = fileNameList;
        }

        private void populateComboBox()
        {

            string[] languages = File.ReadAllLines("languages.txt");
            foreach (var str in languages)
            {
                languageList.Add(str);
            }
            comboBox1.DataSource = languageList;
            var selectedLanguage = comboBox1.SelectedItem;
            sselectedLanguage = selectedLanguage.ToString();

            populateList();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
