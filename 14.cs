Console.Write("Ingrese un número: ");
int n = int.Parse(Console.ReadLine());

if (n % 3 == 0 && n % 5 == 0)
    Console.WriteLine("Es múltiplo de 3 y 5");
else
    Console.WriteLine("No es múltiplo de 3 y 5");
