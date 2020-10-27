using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace VideoGameDIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            UnityContainer container = new UnityContainer();

            container.RegisterType<IWeapons, Sword>(new InjectionConstructor("Slasher"));
            container.RegisterType<IHero, UltimateHero>(new InjectionConstructor("Sword Swinger", typeof(IWeapons)));

            var hero5 = container.Resolve<IHero>();


            Hero hero1 = new Hero("He-Man");
            UltimateHero hero2 = new UltimateHero("Foo-Man", new Grenade("Pineapple"));

            hero1.Attack();

            

            hero2.Attack();

            hero5.Attack();

            Console.ReadLine();
        }
    }
}
