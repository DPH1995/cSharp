using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WWTBAM
{
    public partial class PlayGameForm : Form
    {
        public PlayGameForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameStartedForm gameStartedForm = new GameStartedForm();
            this.Hide();
            gameStartedForm.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            
        }
    }
}
