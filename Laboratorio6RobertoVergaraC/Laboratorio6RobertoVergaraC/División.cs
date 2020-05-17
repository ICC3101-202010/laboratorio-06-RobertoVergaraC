using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class División
    {
        protected string Name;
        protected Persona InCharge;

        public División(string name, Persona inCharge)
        {
            this.Name = name;
            this.InCharge = inCharge;
        }
    }
}
