//Exercício 6 - Cálculo de desconto em produto

double ValorProduto;

Console.WriteLine("Digite um valor para o produto: ");
ValorProduto = double.Parse(Console.ReadLine());

Console.WriteLine("Escolha a forma de pagamento");
Console.WriteLine("1 - À vista");
Console.WriteLine("2 - Parcelado");

int FormaPagamento;
FormaPagamento = int.Parse(Console.ReadLine());

double ValorFinal;

if(FormaPagamento == 1)
{
    ValorFinal = ValorProduto * 0.9;
    Console.WriteLine($"Pagamento à vista. Valor com desconto: R${ValorFinal}");
}
else
{
    ValorFinal = ValorProduto;
    Console.WriteLine($"Pagamento parcelado. Valor sem desconto: R${ValorFinal}");
}