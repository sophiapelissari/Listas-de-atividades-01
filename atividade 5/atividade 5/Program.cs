// See https://aka.ms/new-console-template for more information
int nvb;
int nvn;
int nvv;
Console.WriteLine("digite o número de votos brancos aqui: ");
nvb = int.Parse(Console.ReadLine());
Console.WriteLine($"a porcenagem é: {nvb/100} %");
Console.WriteLine("digite o número de votos nulos aqui: ");
nvn = int.Parse(Console.ReadLine());
Console.WriteLine($"a porcenagem é: {nvn / 100} %");
Console.WriteLine("digite o número de votos válidos aqui: ");
nvv = int.Parse(Console.ReadLine());
Console.WriteLine($"a porcenagem é: {nvv / 100} %");
Console.WriteLine($"o total e votos foi de: {nvb + nvn + nvv} ");
Console.ReadLine();   