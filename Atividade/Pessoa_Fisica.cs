public class Pessoa_Fisica : Clientes
{
public string CPF { get; set; }
public string RG { get; set; }
// Sobrescrevendo o método PagarImposto para Pessoa Física
public override void PagarImposto(float v)
{
Valor = v;
ValorImposto = Valor * 0.05f; // Exemplo de imposto para Pessoa Física (5%)
Total = Valor + ValorImposto;
}
}