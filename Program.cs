using System.Collections.Generic;

//Criando lista de produtos dinâmica 
//(começando vazia, e vai colocando informacoes conforme o usuário digita)
List<double> precosProdutos = new List<double>();

Console.WriteLine("=== MERCADINHO: REGISTRO DE COMPRAS ===");

double precosDigitado = -1;

//Laço de repetição para a inserção de valores pelo usuário
while (precosDigitado != 0)
{
    Console.WriteLine("Para finalizar digite '0'");
    Console.WriteLine("Digite o preco do produto: R$");
    precosDigitado = double.Parse(Console.ReadLine());

    if(precosDigitado > 0)
    {
        //adiciona o valor digitado a Lista precosProdutos com .Add()
        precosProdutos.Add(precosDigitado);
    }
}

double valorTotal = CalcularTotalCompra(precosProdutos);

Console.WriteLine("=========================================");
Console.WriteLine($"Quantidade de itens comprados: {precosProdutos.Count}");
Console.WriteLine($"Valor total a pagar: R${valorTotal:F2}");
Console.WriteLine("=========================================");

//Funcao que recebe a lista com os precos por parâmetro, soma-os e RETORNA o total
static double CalcularTotalCompra(List<double> listaPrecos)
{
    double soma = 0;

    //o foreach percorre cada item da lista automaticamente (foreach -forma simplicada do for)
    foreach (double preco in listaPrecos)
    {
        soma += preco;
    }

    return soma;
}
