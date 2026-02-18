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
        }

        public string Titulo { get; }
        public int Duracao { get; }

        public List<Artista> Elenco { get; } = new();

        public void AdicionarElenco(Artista artista)
        {
            if (Elenco.Contains(artista)) return;

            Elenco.Add(artista);
            artista.AdicionarFilme(this); 
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"Filme: {Titulo} ({Duracao} min)");
            Console.WriteLine("Elenco: " + string.Join(", ", Elenco.ConvertAll(a => a.Nome)));
        }

        public void ListarElenco()
        {
            foreach (var item in Titulo)
            {
                
            }
        }
    }
}