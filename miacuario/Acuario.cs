using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miacuario {
    internal class Acuario {
        public string Direccion { get; set; }
        public Delfin Delfin1 { get; set; }
        public Delfin Delfin2 { get; set; }
        public Orca Orca1 { get; set; }

        public void ListaNombres() {
            Console.WriteLine($"Delfin 1: {Delfin1.Nombre}");
            Console.WriteLine($"Delfin 2: {Delfin2.Nombre}");
            Console.WriteLine($"Orca: {Orca1.Nombre}");
        }
    }
}
