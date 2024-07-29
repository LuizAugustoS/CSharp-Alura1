class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }
    public Titular Titular { get; set; };
    public string Nome { get;}
    public string Cpf { get;}
    public string Endereco { get;}
}

public void ExibirTitular ()
{
    Console.WriteLine("Confira os dados do Titular da conta: ");
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"CPF: {Cpf}");
    Console.WriteLine($"Endereço: {Endereco}");
}