using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Inhabitant
    {
        private int age;
        public Inhabitant(int aAge)
        {
            Age = aAge;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 || value < 100)
                { age = value; }
                if (value <= 0)
                { age = 1; }
                if (value > 100)
                { age = 100; }

            }
        }
        public int Eat()
        {
            if (Age <= 12) { return 2; }
            if (Age > 12 || Age <= 25) { return 5; }
            if (Age > 25 || Age <= 60) { return 4; }
            if (Age > 60) { return 3; }
            else { return 0; }
        }
        public override string ToString()
        {
            return "Inhabitant is " + age.ToString() + " years old";
        }
    }
}
