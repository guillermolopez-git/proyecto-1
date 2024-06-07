using ProyectoFinal.ListaEnlazada;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Arbol_Avl;

namespace ProyectoFinal
{
    public partial class Form4 : Form
    {

        private string filePath = "..\\..\\Data\\jugadores.csv";
        private ListaJugador arbol= new ListaJugador();
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string NameBuscado = BuscarName.Text.Trim().Replace("-", "");

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string tuplas;
                    bool encontrado = false;

                    while ((tuplas = reader.ReadLine()) != null)
                    {
                        string[] datos = tuplas.Split(';');

                        if (datos.Length >= 12 && datos[0].Trim().Replace("-", "") == NameBuscado)
                        {
                            MessageBox.Show($"Nombre Completo: {datos[0]}\nEdad: {datos[1]}\nTemporada: {datos[2]}\nPosición: {datos[3]}\nClub Actual: {datos[4]}\nMinutos Jugados En Total: {datos[5]}\nNacionalidad: {datos[6]}\nGoles En Total: {datos[7]}\nAsistencias En Total: {datos[8]}\nGoles De Penalti: {datos[9]}\nTarjetas Amarillas En Total: {datos[10]}\nTarjetas Rojas En Total: {datos[11]}");
                            encontrado = true;
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("Jugador no encontrado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEquipoEliminar = Eliminar.Text.Trim();

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                using (StringWriter sw = new StringWriter())
                {
                    bool eliminado = false;

                    foreach (string line in lines)
                    {
                        string[] datos = line.Split(';');
                        if (datos.Length > 0 && datos[0].Trim() == nombreEquipoEliminar)
                        {
                            eliminado = true;
                            continue;
                        }
                        sw.WriteLine(line);
                    }
                    File.WriteAllText(filePath, sw.ToString());

                    if (eliminado)
                    {
                        MessageBox.Show($"El Jugador \"{nombreEquipoEliminar}\" ha sido eliminado.");
                    }
                    else
                    {
                        MessageBox.Show($"El equipo \"{nombreEquipoEliminar}\" no se encontró.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el equipo: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form furmulario = new Form5();
            furmulario.Show();
        }
    }
}
