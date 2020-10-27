using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameDIDemo
{
    class UltimateHero : IHero
    {
        public string Name { get; set; }
        public IWeapons MyWeapon { get; set; }

        public UltimateHero(string name, IWeapons myWeapon)
        {
            Name = name;
            MyWeapon = myWeapon;
        }

        public void Attack()
        {
            Console.WriteLine(Name + " Prepares to attack!");
            MyWeapon.Attack();
        }
    }
}
