using Filmes.Alura.Filmes;

namespace Alura.Filmes;

class Filme: IFilme
{
    public Filme(string titulo, int duracao)
    {
        Titulo = titulo;
        Duracao = duracao;
    }
    public string Titulo { get; set; }
    public int Duracao { get; set; }
   



    public void ExibirFilmes()
    {
        
    }

    public string ExibirTitulo()
    {
        return this.Titulo;
    }
}