Console.Write("Ingrese la base del triángulo: ");
double baseT = double.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del triángulo: ");
double altura = double.Parse(Console.ReadLine());

double area = (baseT * altura) / 2;
Console.WriteLine("El área del triángulo es: " + area);
