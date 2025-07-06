Console.Write("Ingrese el precio del producto: ");
double precio = double.Parse(Console.ReadLine());

if (precio > 100)
{
    double descuento = precio * 0.1;
    double precioFinal = precio - descuento;
    Console.WriteLine("Se aplica un 10% de descuento. Precio final: $" + precioFinal);
}
else
{
    Console.WriteLine("No hay descuento. Precio final: $" + precio);
}
