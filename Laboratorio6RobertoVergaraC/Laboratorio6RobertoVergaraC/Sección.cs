using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class Sección: División
    {
        public Sección(string Name, Persona InCharge) : base(Name, InCharge)
        {
            this.Name = Name;
            this.InCharge = InCharge;
            this.Type1 = "Sección";
        }
    }
}
