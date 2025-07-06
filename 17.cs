Console.Write("Ingrese la nota del alumno: ");
double nota = double.Parse(Console.ReadLine());

if (nota >= 7)
    Console.WriteLine("El alumno aprueba");
else
    Console.WriteLine("El alumno no aprueba");
