Console.Write("Ingrese un número: ");
int numero = int.Parse(Console.ReadLine());

if (numero > 0)
    Console.WriteLine("El número es positivo");
else if (numero < 0)
    Console.WriteLine("El número es negativo");
else
    Console.WriteLine("El número es cero");
