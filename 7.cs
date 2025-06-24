Console.Write("Ingrese el radio del círculo: ");
double radio = double.Parse(Console.ReadLine());

double areaCirculo = Math.PI * Math.Pow(radio, 2);
Console.WriteLine("El área del círculo es: " + areaCirculo);
