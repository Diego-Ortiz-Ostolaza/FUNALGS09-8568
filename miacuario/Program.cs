// See https://aka.ms/new-console-template for more information
using miacuario;

Delfin d1 = new Delfin();
d1.Nombre = "Flipper";

Delfin d2 = new Delfin();
d2.Nombre = "Roberto";

Orca o1 = new Orca();
o1.Nombre = "Jhon";

Acuario a = new Acuario();
a.Direccion = "Av 1";
a.Delfin1 = d1;
a.Delfin2 = d2;
a.Orca1 = o1;
Console.WriteLine(a.Direccion);
a.ListaNombres();



