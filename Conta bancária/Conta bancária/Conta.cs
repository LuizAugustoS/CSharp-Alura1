class Conta
{
    public int Indicador { get; set; }
    public double Saldo { get; set; }
    public int Senha { get; set; }
    public Titular Titular { get; set; }

    public string ExibirInformacoesConta => $"Nome do titular: {Titular}, Indicador: {Indicador}, Saldo: {Saldo}, Senha: {Senha}";
}   