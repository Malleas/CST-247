using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDIDemo
{
    class Hero : IHero
    {
        public string Name { get; set; }

        public Hero(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            Sword sword = new Sword("Excalibur");
            Console.WriteLine(Name + " Prepares for battle!");
            sword.Attack();
        }
    }
}
