using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes
{
    public class Artista
    {
        public Artista(string nome, int idade, List<string> filmes)
        {
            Nome = nome;
            Idade = idade;
            FilmesAtuados = filmes; 
        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public List<string> FilmesAtuados { get; set; }
    }
}
