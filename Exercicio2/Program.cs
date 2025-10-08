//Exercicio 2 - Verificação de número par ou impar

int Num;

Console.WriteLine("Digite um número inteiro: ");
Num = int.Parse(Console.ReadLine());


if(Num % 2 == 0)
{
    Console.WriteLine("O número é par");
}
else
{
    Console.WriteLine("O número é ímpar");
}