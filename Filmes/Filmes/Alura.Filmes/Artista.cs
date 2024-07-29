using Filmes.Alura.Filmes;

namespace Alura.Filmes;
class Artista
{
    public string Nome { get;}
    public int Idade { get;}
    public List<IFilme> Filmes = new();

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

}