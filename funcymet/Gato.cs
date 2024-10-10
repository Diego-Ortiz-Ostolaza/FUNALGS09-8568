using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace funcymet {
    internal class Gato {
        private string nombre;

        public string GetNombre() {
            return nombre;
        }
        public void SetNombre(string nombre) {
            this.nombre = nombre;
        }

        private int edad;

        public int Edad { get => edad; set => edad = value; }

        public string Raza { get; set; }    //trabajaremos con este
        public string Color { get; set; }    //trabajaremos con este
        public double Peso { get; set; }    //trabajaremos con este
    }
}
