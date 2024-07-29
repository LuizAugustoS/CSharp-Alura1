using Alura.Filmes;
using Filmes.Alura.Filmes;

Filme filme1 = new Filme("O senhor dos Aneis", 280);
Filme filme2 = new Filme("Clube da Luta", 150);
Filme filme3 = new Filme("Homem do Futuro", 115);
Filme filme4 = new Filme("O Homem que Mudou o Jogo", 133);
FilmeXpto filmeXpto1 = new FilmeXpto("Duro de matar 3");
FilmeXpto filmeXpto2 = new FilmeXpto("Tropa de Elite 2");

List<IFilme> filmes = new();
filmes.Add(filme1);
filmes.Add(filme2);
filmes.Add(filme3);
filmes.Add(filme4);
filmes.Add(filmeXpto1);
filmes.Add(filmeXpto2);

foreach (var filme in filmes)
    Console.WriteLine($"Filmes: {filme.ExibirTitulo()}");
/*
Artista artista1 = new Artista("Virgo", 46);
Artista artista2 = new Artista("Brad Pitt", 34);
Artista artista3 = new Artista("Vagner Moura", 37);

artista1.Filmes.Add(filme1);
artista2.Filmes.Add(filme2);
artista3.Filmes.Add(filme3);
artista2.Filmes.Add(filme4);
List<Artista> artistas = new();
artistas.Add(artista1);
artistas.Add(artista2);
artistas.Add(artista3);
foreach (Artista artista in artistas)
{
    Console.WriteLine($"Artistas: { artista.Nome}, { artista.Idade}, {string.Join(",", artista.Filmes.Select(f=>f.Titulo))}");
}
*/