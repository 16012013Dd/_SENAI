public class Program
{
public static void Main()
{
// Criação de uma instância de Pessoa Física
Pessoa_Fisica pessoaFisica = new Pessoa_Fisica();
pessoaFisica.Nome = "Verônica Pimentel";
pessoaFisica.Endereco = "Rua b, 12";
pessoaFisica.CPF = "000.111.222-00";
pessoaFisica.RG = "4.567-45";
pessoaFisica.PagarImposto(1000f);
Console.WriteLine("Informações de Pessoa Física:");
pessoaFisica.ExibirInformacoes();
// Criação de uma instância de Pessoa Jurídica
Pessoa_Juridica pessoaJuridica = new Pessoa_Juridica();
pessoaJuridica.Nome = "Empresa Left Ltda";
pessoaJuridica.Endereco = "Av. Central, 122";
pessoaJuridica.CNPJ = "13.458.0001-22";
pessoaJuridica.IE = "154758";
pessoaJuridica.PagarImposto(1000f);
Console.WriteLine("\nInformações de Pessoa Jurídica:");
pessoaJuridica.ExibirInformacoes();
}
}