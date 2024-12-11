using System;
public class Clientes
{
// Propriedades públicas e privadas (encapsulamento)
public string Nome { get; set; }
public string Endereco { get; set; }
protected float Valor { get; set; }
protected float ValorImposto { get; set; }
protected float Total { get; set; }
// Método para calcular imposto (polimorfismo)
public virtual void PagarImposto(float v)
{
Valor = v;
ValorImposto = Valor * 0.1f; // Exemplo de cálculo de imposto padrão (10%)
Total = Valor + ValorImposto;
}
// Exibir informações
public void ExibirInformacoes()
{
Console.WriteLine($"Nome: {Nome}");
Console.WriteLine($"Endereço: {Endereco}");
Console.WriteLine($"Valor: {Valor}");
Console.WriteLine($"Valor do Imposto: {ValorImposto}");
Console.WriteLine($"Total a Pagar: {Total}");
}
}