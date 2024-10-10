using funcymet;

Gato g = new Gato();
g.SetNombre("Michi");
g.Edad = 5;
g.Raza = "Siames";

Console.WriteLine($"Mi gato {g.GetNombre()}, tiene {g.Edad} años y es {g.Raza}");

Gato catnoir = new Gato();
catnoir.SetNombre("XYZ");