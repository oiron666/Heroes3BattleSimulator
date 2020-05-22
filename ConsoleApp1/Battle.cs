using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Heroes3BattleSimulator
{
    public class Battle
    {
        static void Main(string[] args)
        {

            Unit firstCreature;
            Unit secondCreature;
            Console.WriteLine("FIRST CREATURE");
            Console.WriteLine("What's the name of your first creature");
            string name = Console.ReadLine();
            Console.WriteLine("What's creature min damage");
            int minDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature max damage");
            int maxDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature hp");
            int hp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature speed");
            int speed = Convert.ToInt32(Console.ReadLine());
            firstCreature = new Unit(name, minDamage, maxDamage, hp, speed  );

            Console.WriteLine("SECOND CREATURE");
            Console.WriteLine("What's the name of your first creature");
            name = Console.ReadLine();
            Console.WriteLine("What's creature min damage");
            minDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature max damage");
            maxDamage = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature hp");
            hp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What's creature speed");
            speed = Convert.ToInt32(Console.ReadLine());
            secondCreature = new Unit(name, minDamage, maxDamage, hp, speed);
            Console.WriteLine(firstCreature.name +
                                "\nIt takes between " + firstCreature.minDamage + " and " + firstCreature.maxDamage + " damage" +
                                "\nIt has " + firstCreature.hp + "HP and " + firstCreature.speed + " speed"
                                );

            Console.WriteLine(  secondCreature.name + 
                                "\nIt takes between " + secondCreature.minDamage + " and " + secondCreature.maxDamage + " damage" +
                                "\nIt has " + secondCreature.hp + "HP and " + secondCreature.speed + " speed"
                                );



        }
    }
}
