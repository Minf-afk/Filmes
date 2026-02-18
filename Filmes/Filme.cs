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
            Elenco = new List<string>();
        }
        public string Titulo { get; set; }
        public int Duracao { get; set; }
        public List<string> Elenco { get;}

        public void AdicionarElenco()
        {
            Console.WriteLine("Digite o nome do artista deste filme: \n");
            string nomeArtista = Console.ReadLine();
            Elenco.Add(nomeArtista);
        }

        public void ListarElenco()
        {

            Console.WriteLine("Elenco: \n");
            foreach (var itens in Elenco)
            {
                Console.WriteLine($"{itens}");
            }
        }

        public void MostrarDetalhes()
        {
            Console.WriteLine($"O filme: {Titulo} tem duração de: {Duracao} e conta com o grande elenco: {string.Join(", ",Elenco)}");
            
        }
    }
}
