using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Defender : Inhabitant
    {
        public Defender(int aAge) : base(aAge)
        {
        }

        public virtual string ReadyToFight()
        {
            return "Ready to fight!";
        }

    }
}
