//Exercicio 8 - Calculo da media ponderada e conceito

float Nota1, Nota2, Nota3, Peso1, Peso2, Peso3;

Console.WriteLine("Digite a primeira nota: ");
Nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
Peso1 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
Nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
Peso2 = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a primeira nota: ");
Nota3 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o peso da primeira nota: ");
Peso3 = float.Parse(Console.ReadLine());

float Media = ((Nota1 * Peso1) + (Nota2 * Peso2) + (Nota3 * Peso3)) / (Peso1 + Peso2 + Peso3);

Console.WriteLine($"A média ponderada é: {Media}");

char Conceito;

if(Media >= 9)
{
    Conceito = 'A';
}else if(Media >= 7)
{
    Conceito = 'B';
}else if(Media >= 5)
{
    Conceito = 'C';
}
else
{
    Conceito = 'D';
}

Console.WriteLine($"Conceito: {Conceito}");