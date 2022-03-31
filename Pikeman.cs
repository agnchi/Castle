using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Castle
{
    class Pikeman : Defender
    {
        public Pikeman(int aAge) : base(aAge)
        {
        }

        public override string ReadyToFight()
        {
            return "The pikeman is ready to fight!";
        }
    }
}
