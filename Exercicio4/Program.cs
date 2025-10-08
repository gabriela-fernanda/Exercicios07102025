//Exercicio 4 - Cálculo de IMC 

float Altura, Peso;

Console.WriteLine("Digite sua altura: ");
Altura = float.Parse(Console.ReadLine());

Console.WriteLine("Digite seu peso: ");
Peso = float.Parse(Console.ReadLine());

float Imc = Peso / (Altura *  Altura);

if(Imc < 18.5)
{
    Console.WriteLine("Abaixo do peso");
}else if(Imc >= 18.5 && Imc < 24.9)
{
    Console.WriteLine("Peso normal");
}else if(Imc >= 25 && Imc < 29.9)
{
    Console.WriteLine("Sobrepeso");
}
else
{
    Console.WriteLine("Obesidade");
}