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
            var cliente1 = new Cliente(001,"Pedro","90899878","San Pedro Sula,", "El Pedregal");
            var cliente2 = new Cliente(002, "Salomon","90901221", "Tegucigalpa,", "San Francisco");
            var cliente3 = new Cliente(003, "Teresa", "98978900 ", "El Progreso,", "Altos de Progreso");

            var cliente = new List<Cliente>();
            cliente.Add(cliente1);
            cliente.Add(cliente2);
            cliente.Add(cliente3);



            foreach (var Clientes in cliente)
            
                MessageBox.Show(Clientes.Id + " " + Clientes.Nombre + " " +Clientes.Telefono+ " "+ Clientes.Ciudad +" "+Clientes.Direcion );

            }

        }
    }

