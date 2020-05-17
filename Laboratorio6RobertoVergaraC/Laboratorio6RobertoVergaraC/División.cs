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
        private string name;
        private string type1;
        private Persona inCharge;
        private List<Persona> generalPersonal;

        public string Name { get => name; set => name = value; }
        public string Type1 { get => type1; set => type1 = value; }
        public Persona InCharge { get => inCharge; set => inCharge = value; }
        internal List<Persona> GeneralPersonal { get => generalPersonal; set => generalPersonal = value; }

        public División(string name, Persona inCharge)
        {
            this.Name = name;
            this.InCharge = inCharge;
        }
    }
}
