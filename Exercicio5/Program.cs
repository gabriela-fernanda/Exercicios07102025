//Exercício 5 - Verificação de Múltiplos

int Num1, Num2;

Console.WriteLine("Digite um numero inteiro: ");
Num1 = int.Parse(Console.ReadLine());


Console.WriteLine("Digite outro numero inteiro: ");
Num2 = int.Parse(Console.ReadLine());

if(Num1 % Num2 == 0)
{
    Console.WriteLine($"Os numeros {Num1} e {Num2} são múltiplos");
}
else
{
    Console.WriteLine($"Os numeros {Num1} e {Num2} não são múltiplos");
}