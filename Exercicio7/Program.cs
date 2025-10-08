//Exercicio 7 - Classificação de triangulo

int Lado1, Lado2, Lado3;

Console.WriteLine("Digite o valor do primeiro lado: ");
Lado1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do segundo lado: ");
Lado2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor do terceiro lado: ");
Lado3 = int.Parse(Console.ReadLine());

if(Lado1 < Lado2 + Lado3 && Lado2 < Lado1 + Lado3 && Lado3 < Lado1 + Lado2)
{
    Console.WriteLine("Os valores formam um tringulo");

    if(Lado1 == Lado2 && Lado2 == Lado3)
    {
        Console.WriteLine("É um triangulo equilatero");
    }else if(Lado1 == Lado2 || Lado1 == Lado3 || Lado2 == Lado3)
    {
        Console.WriteLine("É um triangulo isosceles");
    }
    else
    {
        Console.WriteLine("É um triangulo escaleno");
    }
}
else
{
    Console.WriteLine("Os valores não formam um triangulo");
}