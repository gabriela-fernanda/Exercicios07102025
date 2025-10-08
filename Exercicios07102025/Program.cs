//Exercicio 1 - Calculo de média e aprovação

float Nota1, Nota2, Nota3;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a segunda nota: ");
Nota2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a terceira nota: ");
Nota3 = float.Parse(Console.ReadLine());

float Media = (Nota1 + Nota2 + Nota3) / 3;

Console.WriteLine("A média é: " + Media);

if(Media >= 7)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}



