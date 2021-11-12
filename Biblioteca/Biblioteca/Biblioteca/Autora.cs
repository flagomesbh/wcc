using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Autora
    {
        private string _nome { get; set; }
        public Autora()
        {

        }
        
        public Autora(string nome)
        {
            _nome = nome;
        }
        
        public string Nome
        { 
            get { return _nome; } 
            set { _nome = value; }
        }
    }
}
