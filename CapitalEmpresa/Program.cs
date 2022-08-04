// See https://aka.ms/new-console-template for more information
Console.WriteLine("Capital de Empresa");
Console.WriteLine("");

double monto1, monto2, monto3,capital, ps1,ps2,ps3;

Console.WriteLine("Ingrese el monto 1: ");
monto1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese monto 2: ");
monto2 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el monto 3:");
monto3 = double.Parse(Console.ReadLine());

capital = (monto1 + monto2 + monto3);
ps1= (monto1 * 100) / capital;
ps2= (monto2 * 100) / capital;
ps3 = (capital * 100) / capital;

Console.WriteLine("-----------------------");
Console.WriteLine("La capital es: "+capital.ToString());
Console.WriteLine("El porcentaje del socio 1 es: C$"+ps1.ToString());
Console.WriteLine("El porcentaje del socio 2 es: C$"+ps2.ToString());
Console.WriteLine("El porcentaje del socio 3 es: C$" +ps3.ToString());



