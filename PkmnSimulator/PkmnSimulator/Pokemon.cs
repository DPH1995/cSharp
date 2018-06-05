using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PkmnSimulator
{

    public class Pokemon
    {
        public string name { get; set; }
        public int id { get; set; }
        public int level { get; set; }
        public int hp { get; set; }
        public int exp { get; set;  }
        public string[] Moves { get; set; }
        public System.Drawing.Image sprite { get; set; }
        
        public Pokemon()
        {

        }

        public Pokemon(string name, int id, int level, int hp, int exp, string[] moves, System.Drawing.Image sprite)
        {
            this.name = name;
            this.id = id;
            this.level = level;
            this.hp = hp;
            this.exp = exp;
            Moves = moves;
            this.sprite = sprite;
        }

       
      

        
    }
}


