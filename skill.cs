using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace conselmon
{
    internal class skill
    {
        public int dam;
        public int costenergy;
        public string name;
        internal void UseOn(Consolemon tarrget, Consolemon caster)
        {
            caster.DepleteEnergy(costenergy);
            tarrget.TakeDamage(dam);
        }

    }
}
