// See https://aka.ms/new-console-template for more information
Console.WriteLine("Control de ventas del producto");

int cantidad,precio;

Console.WriteLine("El precio del producto es: ");
precio = int.Parse(Console.ReadLine());

Console.WriteLine("La cantidad es de:");
cantidad = int.Parse(Console.ReadLine());

Console.WriteLine("----------------------");

int importe = precio * cantidad;
Console.WriteLine("El importe de la compra es de:"+importe.ToString());

int descuento = importe* 11/100;
Console.WriteLine("El descuento del producto fue de:"+descuento.ToString());

double total = importe - descuento;

Console.WriteLine("EL TOTAL A PAGAR ES DE:"+total.ToString());





