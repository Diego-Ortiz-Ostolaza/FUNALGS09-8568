using carrosygatos.animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrosygatos.persona {
    internal class Domador {
        public string Nombre { get; set; }
        public Tigre TigreFav { get; set; }


        public void Domar() {
            Tigre t = new Tigre();
        }
    }
}
