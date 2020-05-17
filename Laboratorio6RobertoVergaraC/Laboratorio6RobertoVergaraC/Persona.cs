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
            this.Name = name;
            this.SurName = surName;
            this.Rut = rut;
            this.Charge = charge;
        }

        public string Name { get => name; set => name = value; }
        public string SurName { get => surName; set => surName = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Charge { get => charge; set => charge = value; }
    }
}
