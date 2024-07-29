namespace PetShop.Petshop
{
    internal class Medico
    {
        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; }
        public string Especialidade { get; }
    }
}
