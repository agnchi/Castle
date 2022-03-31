using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Program
    {
        static void Main(string[] args)
        {
            Civilian John = new Civilian(5);
            Civilian Daniel = new Civilian(90);
            Civilian Anne = new Civilian(10);
            Civilian Caroline = new Civilian(61);
            Pikeman Jack = new Pikeman(23);
            Pikeman Oliver = new Pikeman(17);
            Bowman Micheal = new Bowman(19);
            Defender Gabriel = new Defender(20);
            Defender Thomas = new Defender(16);
            Bowman Anthony = new Bowman(24);

            List<Inhabitant> inhabitants = new List<Inhabitant>();
            List<Defender> defenders = new List<Defender>();
            List<Bowman> bowmen=new List<Bowman>();
            inhabitants.Add(John);
            inhabitants.Add(Daniel);
            inhabitants.Add(Anne);
            inhabitants.Add(Caroline);
            inhabitants.Add(Jack);
            inhabitants.Add(Oliver);
            inhabitants.Add(Micheal);
            inhabitants.Add(Gabriel);
            inhabitants.Add(Thomas);
            inhabitants.Add(Anthony);
            defenders.Add(Jack);
            defenders.Add(Oliver);
            defenders.Add(Micheal);
            defenders.Add(Gabriel);
            defenders.Add(Thomas);
            defenders.Add(Anthony);
            bowmen.Add(Anthony);
            bowmen.Add(Micheal);
            int FoodNeeded = 0;

            Console.WriteLine("List of defenders:");
            foreach(Defender defender in defenders)
            {
                Console.WriteLine(defender.ReadyToFight());
            }
            Console.WriteLine("List of bowmen:");
            foreach (Bowman bowman in bowmen)
            {
                Console.WriteLine(bowman.ReadyToFight());
            }
            Console.WriteLine("List of inhabitants:");
            foreach (Inhabitant inhabitant in inhabitants)
            {
                Console.WriteLine(inhabitant.ToString());
                FoodNeeded = FoodNeeded +inhabitant.Eat();
            }
            Console.WriteLine("The castle needs "+ FoodNeeded+ " food units in total"); 
        }
    }
}