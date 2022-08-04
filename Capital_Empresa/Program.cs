// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ** Capital de la empresa ** ");
Console.WriteLine("");

int monto1, monto2, monto3;

Console.WriteLine("Ingrese el primer moonto: ");
monto1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo monto: ");
monto2 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el tercer monto: ");
monto3 = int.Parse(Console.ReadLine());


int capital = monto1 + monto2 + monto3;

double pSocio1 = (monto1 * 100) / capital;
double pSocio2 = (monto2 * 100) / capital;
double pSocio3 = (monto3 * 100) / capital;

Console.WriteLine("El capital es de: "+capital.ToString("0.00")+ "dolares");
Console.WriteLine("Promedio del socio 1: %" + pSocio1.ToString("0.00"));
Console.WriteLine("Promedio del socio 2: %" + pSocio2.ToString("0.00"));
Console.WriteLine("Promedio del socio 3: %" + pSocio3.ToString("0.00"));













