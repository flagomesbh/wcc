using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livro
    {
        private string _titulo { get; set; }
        private string _descricao { get; set; }
        private double _preco { get; set; }
        private Autora _autora { get; set; }
        private string[] _genero { get; set; }
        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }
        public string Descricao 
        {
            get { return _descricao; }
            set { _descricao = value; }
        }
        public double Preco
        {
            get { return _preco; }
            set { _preco = value; }
        }

        public Autora Autora
        {
            get { return _autora; }
            set { _autora = value; }
        }

        public string[] Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }

        public Livro()
        { }
        
        public Livro(string titulo, string descricao, double preco, Autora autora, string[] genero)
        {
            _titulo = titulo;
            _descricao = descricao;
            _preco = preco;
            _autora = autora;
            _genero = genero;
        }
    }
}
