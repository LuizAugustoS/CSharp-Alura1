

namespace Funcionarios
{
    internal class Funcionario
    {
        public Funcionario(string nome, int salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public string Nome { get; set; }
        public int Salario { get; set; }
    }
    public void FuncionarioNome()
        {
        Console.WriteLine($"Nome: {Nome};

    }
}
