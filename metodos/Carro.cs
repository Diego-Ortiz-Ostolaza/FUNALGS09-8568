using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos {
    public class Carro {

        public string Color { get; set; }
        public string Placa { get; set; }
        public static string Marca { get; set; }

        public void Arrancar() {
            Console.WriteLine("Carro encendido");
        }

        public static void Derrapar() {
            Console.WriteLine("Como R y F");
        }

    }
}
