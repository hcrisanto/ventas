using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var categoria1 = new Categoria(1,"Computadoras");
            var categoria2 = new Categoria(2, "Articulos de PC");
            var categoria3 = new Categoria(3, "Articulos PC");
            var categoria4 = new Categoria(4, "Celulares");
            var categoria5 = new Categoria(5, "Celulares");
            var categoria6 = new Categoria(6, "Consolas");
            
           
            var producto1 = new Producto(001,"PC Gamer",6000, categoria1);
            var producto2 = new Producto(002, "Disco Duro(SSD)", 500,categoria2);
            var producto3 = new Producto(003, "Teclado", 300,categoria3);
            var producto4 = new Producto(004, "Celular Iphone", 10000,categoria4);
            var producto5 = new Producto(005, "Celular Sansumg", 2000,categoria5);
            var producto6 = new Producto(006, "Play statioon", 90000,categoria6);

            var listaproductos = new List<Producto>();
            listaproductos.Add(producto1);
            listaproductos.Add(producto2);
            listaproductos.Add(producto3);
            listaproductos.Add(producto4);
            listaproductos.Add(producto5);
            listaproductos.Add(producto6);



            foreach (var producto in listaproductos)
            {
                MessageBox.Show(producto.Id+" "+ producto.Descripcion +" "+ producto.Precio+"  "+producto.Categoria.Nombre);
                
            }

           
        }
    }
}
