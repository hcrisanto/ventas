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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            var ciudad1 = new Ciudad(23201, "El Progreso");
            var ciudad2 = new Ciudad(21101, "San Pedro Sula");
            var ciudad3 = new Ciudad(11101, "Tegucigalpa");


            var cliente1 = new Cliente(001,"Pedro","90899878",ciudad2, "El Pedregal");
            var cliente2 = new Cliente(002, "Salomon","90901221", ciudad3, "San Francisco");
            var cliente3 = new Cliente(003, "Teresa", "98978900 ", ciudad1, "Altos de Progreso");

           
            var cliente = new List<Cliente>();
            cliente.Add(cliente1);
            cliente.Add(cliente2);
            cliente.Add(cliente3);



            foreach (var Clientes in cliente)
            
                MessageBox.Show(Clientes.Id + " " + Clientes.Nombre + " " +Clientes.Telefono+ " "+ Clientes.Ciudad.Descripcion +", "+Clientes.Direccion );

            }

        }
    }

