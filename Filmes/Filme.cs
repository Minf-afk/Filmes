using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes
{
    public class Filme
    {
        public Filme(string titulo, int duracao, List<string> elenco)
        {
            Titulo = titulo;
            Duracao = duracao;
            Elenco = elenco;
        }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public List<string> Elenco { get; set; }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"O filme: {Titulo} tem duração de: {Duracao} e conta com o grande elenco: {string.Join(", ",Elenco)}");
            
        }
    }
}
