using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filmes.Alura.Filmes
{
    internal class FilmeXpto : IFilme
    {
        public FilmeXpto(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public string ExibirTitulo()
        {
            return this.Nome;
        }
    }
}
