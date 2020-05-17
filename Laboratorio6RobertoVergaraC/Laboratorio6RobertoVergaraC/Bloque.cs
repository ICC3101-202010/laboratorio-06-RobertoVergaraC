using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class Bloque: División
    {
        public Bloque(string Name, Persona InCharge, List<Persona> obreros) : base(Name, InCharge)
        {
            this.Name = Name;
            this.InCharge = InCharge;
            this.GeneralPersonal = obreros;
            this.Type1 = "Bloque";
        }
    }
}
