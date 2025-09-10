// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int n;
Console.WriteLine("DIGITE SEU VALOR PARA DESCOBRIR SE É POSITIVO OU NEGATIVO: ");
n = int.Parse(Console.ReadLine());
if (n == 0)
{
   Console.WriteLine("VALOR INVÁLIDO!");

}
else if (n >0)
{
   Console.WriteLine("SEU NÚMERO É POSITIVO!");
}
else
{
    Console.WriteLine("SEU NÚMERO É NEGATIVO!");
}