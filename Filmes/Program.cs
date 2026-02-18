using Filmes;

Filme harry = new("Harry Potter", 251);
harry.AdicionarElenco();

Filme djangoLivre = new("Django Livre", 320);
djangoLivre.AdicionarElenco();


harry.MostrarDetalhes();
djangoLivre.MostrarDetalhes();

Artista will = new("Will Smith", 25);
will.AdicionarFilmes("Em busca da Felicidade");