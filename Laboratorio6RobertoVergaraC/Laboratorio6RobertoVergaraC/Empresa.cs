﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6RobertoVergaraC
{
    [Serializable]
    class Empresa
    {
        private string name;
        private string rut;
        private List<División> divisions;

        public string Name { get => name; set => name = value; }
        public string Rut { get => rut; set => rut = value; }
        public List<División> Divisions { get => divisions; set => divisions = value; }

        public Empresa() { }
        
        public Empresa(string name, string rut, List<División> divisions)
        {
            this.name = name;
            this.rut = rut;
            this.divisions = divisions;
        }
    }
}
