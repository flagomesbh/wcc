using System;
using System.Collections.Generic;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autora autora = new Autora("Djamila Ribeiro");
            Console.WriteLine(autora.Nome);

            Livro livro = new Livro();
            livro.Titulo = "Lugar de Fala";
            livro.Autora = autora;
            livro.Preco = 25.90;

            Livro livroDois = new Livro()
            {
                Titulo = "Divergente",
                Autora = new Autora("Fulana de tal"),
                Preco = 35.00
            };

            // Livro livroTres = new Livro("titulo", "descricao", 12.99, autora, generos);

            List<Livro> listaLivro = new List<Livro>();
            listaLivro.Add(livro);
            listaLivro.Add(livroDois);

            List<Livro> listaLivroDois = new List<Livro>()
            {
                livro,
                livroDois
            };
        }
    }
}
