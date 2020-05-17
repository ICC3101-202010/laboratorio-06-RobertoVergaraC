using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class Área: División
    {
        public Área(string Name, Persona InCharge) : base (Name, InCharge)
        {
            this.Name = Name;
            this.InCharge = InCharge;
        }
    }
}
