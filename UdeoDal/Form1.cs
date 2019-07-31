using Modelos;
using Modelos.Vehiculo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UdeoDal.Reader;

namespace UdeoDal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PersonaReader reader = new PersonaReader();
                Collection<PersonaModel> personas = reader.Execute();
                foreach (PersonaModel p in personas)
                {
                    MessageBox.Show(string.Format("{0}, {1}, {2}", p.Nombre, p.Apellido, p.Direccion));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                VehiculoReader reader = new VehiculoReader();
                Collection<Vehiculo> vehiculos = reader.Execute();
                foreach (Vehiculo v in vehiculos)
                {
                    MessageBox.Show(string.Format("{0 } - {1 } - {2 }- {3 }- {4 }- {5 }", 
                        v.TipodeVehiculo, v.Marca, v.Linea, v.Modelo, v.Color,v.Transmision));
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}