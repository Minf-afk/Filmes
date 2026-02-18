using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes
{
    public class Artista
    {
        public Artista(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = new List<string>();
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> FilmesAtuados { get; set; }

        public void AdicionarFilmes(string filme)
        {
            FilmesAtuados.Add(filme);
        }
    }
}
