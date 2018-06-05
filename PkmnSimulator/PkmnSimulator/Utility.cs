using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PkmnSimulator
{
    public class Utility
    {
        string lineToUpdate;
        int lineNumber;

        public void updateItemAmount(string username, string item)
        {
            string path = @"C:\Users\Me\Desktop\sim\" + username + ".txt";
          
            switch (item)
            {
                case "Potion":
                    lineNumber = 13;
                    break;
                case "Super potion":
                    lineNumber = 14;
                    break;
                case "PokeBall":
                    lineNumber = 9;
                    break;
                case "GreatBall":
                    lineNumber = 10;
                    break;
                case "UltraBall":
                    lineNumber = 11;
                    break;
                case "MasterBall":
                    lineNumber = 12;
                    break;

            }

            //update value   
            string filePath = @"C:\Users\Me\Desktop\sim\" + username + ".txt";
            var lines = File.ReadAllLines(filePath);
            var iitemCount = lines[lineNumber];
            int amt = Int32.Parse(iitemCount);
           // MessageBox.Show(amt.ToString());
            int updated = amt - 1;
            lines[lineNumber] = updated.ToString();
          //  MessageBox.Show(lines[lineNumber]);
            File.WriteAllLines(filePath, lines);
        }
    }
}
