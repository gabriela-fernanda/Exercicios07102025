// Exercício 3 - Maior de dois números

int Num1, Num2;

Console.WriteLine("Digite um número inteiro");
Num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite outro número inteiro");
Num2 = int.Parse(Console.ReadLine());

if(Num1 > Num2)
{
    Console.WriteLine($"O número {Num1} é maior");
}
else
{
    Console.WriteLine($"O número {Num2} é maior");
}