using Filmes;

Filme harry = new("Harry Potter", 251, new List<string> 
{ 
    "Rupert Grint",
    "Hermione Granger", 
    "Tom Felton" 
});

Filme djangoLivre = new("Django Livre", 320, new List<string>
{
    "Jamie Foxx",
    "Kerry Washington",
    "James Remar"
});

harry.MostrarDetalhes();
djangoLivre.MostrarDetalhes();

Artista will = new("Will Smith", 25, new List<string>
{
    "Em busca da Felicidade"
});