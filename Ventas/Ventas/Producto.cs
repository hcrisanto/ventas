﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }


        public Producto()
        {
        }
        public Producto(int codigo, string descripcion, double precio, Categoria cat)
        {
            Id = codigo;
            Descripcion = descripcion;
            Precio = precio;
            Categoria = cat;

        }


    }
}

 

   
