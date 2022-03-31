using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Bowman : Defender
    {
        public Bowman(int aAge) : base(aAge)
        {
        }

        public override string ReadyToFight()
        {
            return "The bowman is ready to fight!";
        }
    }
}
