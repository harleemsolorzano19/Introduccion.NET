// See https://aka.ms/new-console-template for more information
Console.WriteLine("**CALCULADORA DE MONTOS");
Console.WriteLine("");

double precio;
int cantidad;
Console.WriteLine("Ingrese el precio del producto C$: ");
precio = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad seleccionada:");
cantidad = int.Parse(Console.ReadLine());

double monto = precio * cantidad;

Console.WriteLine("----------------------------");
Console.WriteLine("MONTO A CANSELAR C$:"+monto.ToString("0.00"));

//Console.WriteLine();



