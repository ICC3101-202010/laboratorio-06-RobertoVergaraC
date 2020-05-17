using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    class Persona
    {
        private string name;
        private string surName;
        private string rut;
        private string charge;

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Charge { get => charge; set => charge = value; }
    }
}
