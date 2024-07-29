
namespace PetShop.Petshop
{
    internal class Pet
    {
        public Pet(string nome, int idade, string tipo, string raca)
        {
            Nome = nome;
            Idade = idade;
            Tipo = tipo;
            Raca = raca;
        }

        public string Nome { get; set; }
        public int Idade { get; }
        public string Raca { get; }
        public string Tipo { get; }
     

    }
}
