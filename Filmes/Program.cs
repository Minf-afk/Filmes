using System;
using Filmes;

class Program
{
    static void Main()
    {
        Artista rupert = new Artista("Rupert Grint", 35);
        Artista emma = new Artista("Emma Watson", 33);
        Artista tom = new Artista("Tom Felton", 36);

        Artista jamie = new Artista("Jamie Foxx", 56);
        Artista kerry = new Artista("Kerry Washington", 47);
        Artista remar = new Artista("James Remar", 70);

        Filme harry = new Filme("Harry Potter", 251);
        Filme django = new Filme("Django Livre", 165);

        harry.AdicionarElenco(rupert);
        harry.AdicionarElenco(emma);
        harry.AdicionarElenco(tom);

        django.AdicionarElenco(jamie);
        django.AdicionarElenco(kerry);
        django.AdicionarElenco(remar);

        Console.WriteLine("=== DETALHES DOS FILMES ===");
        harry.MostrarDetalhes();
        Console.WriteLine();
        django.MostrarDetalhes();
        Console.WriteLine();

        Artista samuel = new Artista("Samuel L. Jackson", 75);
        django.AdicionarElenco(samuel);

        Console.WriteLine("=== DJANGO APÓS ADICIONAR MAIS UM ARTISTA ===");
        django.MostrarDetalhes();
        Console.WriteLine();

        Console.WriteLine("=== FILMES ATUADOS ===");
        rupert.MostrarFilmesAtuados();
        Console.WriteLine();
        samuel.MostrarFilmesAtuados();
        Console.WriteLine();

        Console.WriteLine("=== QUANTIDADE DE FILMES POR ARTISTA ===");
        Console.WriteLine($"{rupert.Nome}: {rupert.QuantidadeDeFilmes}");
        Console.WriteLine($"{samuel.Nome}: {samuel.QuantidadeDeFilmes}");

        Console.ReadLine();
    }
}
