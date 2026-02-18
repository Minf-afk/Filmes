using System;
using System.Collections.Generic;
using System.Text;

namespace Filmes
{
    public class Filme
    {
        public Filme(string titulo, int duracao)
        {
            Titulo = titulo;
            Duracao = duracao;
            elenco = new List<string>();
        }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public List<string> Elenco { get;}

        public void AdicionarElenco(string elenco)
        {
            Elenco.Add(elenco);
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"O filme: {Titulo} tem duração de: {Duracao} e conta com o grande elenco: {string.Join(", ",Elenco)}");
            
        }
    }
}
