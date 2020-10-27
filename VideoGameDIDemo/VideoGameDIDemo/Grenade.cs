 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDIDemo 
{
    class Grenade : IWeapons
    {
        public string Name { get; set; }

        public Grenade(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Console.WriteLine(Name + " Smokes and hisses and then explodes");
        }
    }
}
