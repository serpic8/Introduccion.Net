// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** CONVERSION DE MEDIDAS ** ");
Console.WriteLine("");

int metro;

Console.WriteLine("Ingrese la medida en metros a convertir");
metro = int.Parse(Console.ReadLine());

double cm = metro * 100;
Console.WriteLine("La medida en cm es de: "+cm.ToString("0.00"));

double pulgada = cm / 2.54;
Console.WriteLine("La medida en pulgada es de: "+pulgada.ToString("0.00"));

double pies = pulgada / 12;
Console.WriteLine("La medida en pies es de: "+pulgada.ToString("0.00"));

double yardas = pies / 3;
Console.WriteLine("La medida en yardas es de: "+yardas.ToString("0.00"));










