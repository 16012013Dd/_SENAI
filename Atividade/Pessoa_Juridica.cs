public class Pessoa_Juridica : Clientes
{
public string CNPJ { get; set; }

public string IE { get; set; }
// Sobrescrevendo o método PagarImposto para Pessoa Jurídica
public override void PagarImposto(float v)
{
Valor = v;
ValorImposto = Valor * 0.15f; // Exemplo de imposto para Pessoa Jurídica (15%)
Total = Valor + ValorImposto;
}
}