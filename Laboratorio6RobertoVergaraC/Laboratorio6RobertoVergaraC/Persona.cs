using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class Persona
    {
        private string name;
        private string surName;
        private string rut;
        private string charge;

        public Persona(string name, string surName, string rut, string charge)
        {
            this.name = name;
            this.surName = surName;
            this.rut = rut;
            this.charge = charge;
        }
    }
}
