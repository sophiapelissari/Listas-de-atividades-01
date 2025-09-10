// See https://aka.ms/new-console-template for more information
int salario;
float reajuste;

Console.WriteLine("Digite o valor do seu salário: ");
salario = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor do seu reajuste: ");
reajuste = float.Parse(Console.ReadLine());
Console.WriteLine($"o valor do seu novo salário é: {(reajuste / 100 * salario) + salario} ");
