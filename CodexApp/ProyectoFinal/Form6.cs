using ProyectoFinal.TablaHash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Arbol_Avl;

using ProyectoFinal.TablaHash;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class Form6 : Form
    {
        private string filePath = "..\\..\\Data\\Partidos1.csv";
        private HashTable hashTableInstance;

        public Form6()
        {
            InitializeComponent();
            hashTableInstance = new HashTable();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string carneBuscado = Buscar.Text.Trim().Replace("-", "");

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string tuplas;
                    bool encontrado = false;

                    while ((tuplas = reader.ReadLine()) != null)
                    {
                        string[] datos = tuplas.Split(';');

                        if (datos[2].Trim().Replace("-", "") == carneBuscado) // Corregido el índice para buscar por el nombre del equipo local
                        {
                            if (!encontrado)
                            {
                                MessageBox.Show($"Fecha y hora del partido: {datos[0]}\nAsistencia (número de espectadores): {datos[1]}\nNombre del equipo local: {datos[2]}\nNombre del equipo visitante: {datos[3]}\nÁrbitro del partido: {datos[4]}\nCantidad de goles del equipo local: {datos[5]}\nCantidad de goles del equipo visitante: {datos[6]}\nPosesión del equipo local (porcentaje): {datos[7]}\nPosesión del equipo visitante (porcentaje): {datos[8]}\nNombre del estadio: {datos[9]}");
                            }
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("No se encontró ningún partido para el equipo ingresado.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEquipoEliminar = textBox2.Text.Trim();

            try
            {
                hashTableInstance.EliminarPartido(nombreEquipoEliminar);

                MessageBox.Show($"El equipo \"{nombreEquipoEliminar}\" ha sido eliminado correctamente de la Hashtable.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el equipo de la Hashtable: {ex.Message}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


