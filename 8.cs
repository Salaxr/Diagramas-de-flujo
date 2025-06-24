Console.Write("Ingrese la base del rectángulo: ");
double baseR = double.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del rectángulo: ");
double alturaR = double.Parse(Console.ReadLine());

double perimetro = 2 * (baseR + alturaR);
Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
