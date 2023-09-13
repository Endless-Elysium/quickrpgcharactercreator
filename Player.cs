using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlanketRPG
{
    internal class Player
    {

        public string Name;
        private int _hp;
        public int HP
        {
            get { return _hp; }
            set { 
                _hp = Math.Clamp(value, 0, Vit * Str + 10);
            }
        }
        private int _vit;
        public int Vit 
        { 
            get { return _vit; }
            private set
            {
                _vit = value;
                UpdateHP();
            }
        }
        private int _str;
        public int Str
        {
            get { return _str; }
            private set
            {
                _str = value;
                UpdateHP();
            }
        }
        public int Dex { get; private set; }
        public int Mag {  get; private set; }
        public int Agi { get; private set; }


        public int Speed
        {
            get { return Agi * 2; }
        }

        private void UpdateHP()
        {
            HP = _hp = Math.Clamp(HP, 0, Vit * Str + 10);
        }


        public Player(string name, int v, int s, int d, int m, int a)
        {
            Name = name;
            Vit = v;
            Str = s;
            Dex = d;
            Mag = m;
            Agi = a;
            HP = 100000;
        }

        public override string ToString()
        {
            return $"{Name} HP:{HP} VIT:{Vit} STR{Str} DEX{Dex} MAG{Mag} AGI{Agi}";
        }
    }
}
