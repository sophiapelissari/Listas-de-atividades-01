// See https://aka.ms/new-console-template for more information
int n;
Console.WriteLine("DIGITE A QUANTIDADE DE MAÇÃS COMPRADAS: ");
n = int.Parse(Console.ReadLine());
if(n > 12)
{
    Console.WriteLine($"O VALOR A PAGAR É: { n * 1}");
}
else
{
    Console.WriteLine($"O VALOR A PAGAR É: {n * 1.30}");
}
