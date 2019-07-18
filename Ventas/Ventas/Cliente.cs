using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Cliente
    {
       
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direcion { get; set; }

        public Cliente(int id, string nombre, string tel,string ciudad, string direccion)
        {
            Id = id;
            Nombre = nombre;
            Telefono = tel;
            Ciudad = ciudad;
            Direcion = direccion;
        }
    }

    }
    
