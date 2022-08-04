// See https://aka.ms/new-console-template for more information
Console.WriteLine("CONVERSION DE MEDIDA");
Console.WriteLine("");

double metros;
Console.WriteLine("Ingrese la cantidad de metros:");
metros = double.Parse(Console.ReadLine());

double centimetros = metros * 100;
double pulgadas = centimetros / 2.54;
double pies = pulgadas / 12;



