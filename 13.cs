Console.Write("Ingrese el primer número: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo número: ");
int b = int.Parse(Console.ReadLine());

Console.Write("Ingrese el tercer número: ");
int c = int.Parse(Console.ReadLine());

int mayor = a;

if (b > mayor) mayor = b;
if (c > mayor) mayor = c;

Console.WriteLine("El mayor número es: " + mayor);
