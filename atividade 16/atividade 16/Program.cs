int num;
Console.WriteLine("digite um número inteiro para descobrir o valor de seu fatorial: ");
num = int.Parse(Console.ReadLine());
if (num < 0)
{
    Console.WriteLine("NEGATIVO, NÃO EXISTE");
}
else if (num == 0)
{
    Console.WriteLine("POR DEINIÇÃO IGUAL A 1");
}
else
{
    int contador = 1;
    int resultado = 1;
    while (contador <= num)
    {
        resultado *= contador;  
        contador++;
    }
    Console.WriteLine(resultado);
}