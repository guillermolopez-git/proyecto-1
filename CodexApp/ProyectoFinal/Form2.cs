using ProyectoFinal.TablaHash;
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
    public partial class Form2 : Form
    {
        private string filePath = "..\\..\\Data\\equipos.csv";
        private ArbolAVL arbol = new ArbolAVL();
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string NameBuscado = Buscar.Text.Trim().Replace("-", "");

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
                            MessageBox.Show($"nombre delequipo: {datos[0]}\npartidos jugados: {datos[1]}\npartidos ganados : {datos[2]}\nGoles anotados: {datos[3]}\nCiudad: {datos[4]}\ndiferencia de goles: {datos[5]}\ngoles encontra: {datos[6]}\npartidos perdidos : {datos[7]}\npartidos empatados: {datos[8]}\ntotal de goles: {datos[9]}");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreEquipoEliminar = EliminarAVL.Text.Trim();

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
                        MessageBox.Show($"El equipo \"{nombreEquipoEliminar}\" ha sido eliminado.");
                    }
                    else
                    {
                        MessageBox.Show($"El equipo \"{nombreEquipoEliminar}\" no se encontró en el archivo CSV.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el equipo: {ex.Message}");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form furmulario = new Form3();
            furmulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
