using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nombre { get; set; }

        public Categoria()
        {
        }
        public Categoria(int cod, string nombre)
        {
            Id = cod;
            Nombre = nombre;
        }
    }
}

