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
    public partial class Form3 : Form
    {

        private string filePath = "..\\..\\Data\\equipos.csv";
        private ArbolAVL arbol = new ArbolAVL();
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombreEquipo = nombre.Text.Trim();
            string paisEquipo = pais.Text.Trim();
            string Ciudad = ciudad.Text.Trim();
            string partidosjugados = Partidosjugados.Text.Trim();
            string golesanotados = golesAnotados.Text.Trim();
            string diferenciaGoles = diferanciaGoles.Text.Trim();
            string golescontra = golesContra.Text.Trim();
            string partidosperdidos = partidosPerdidos.Text.Trim();
            string partidosempate = partidosEmpatados.Text.Trim();
            string partidosganados = partidosGanados.Text.Trim();
            string totalgoles = Totalgoles.Text.Trim();

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{nombreEquipo};{paisEquipo};{Ciudad};{partidosjugados};{golesanotados};{diferenciaGoles};{golescontra};{partidosperdidos};{partidosempate};{partidosganados};{totalgoles}");
                }

                MessageBox.Show(" Guardado Exitosamente .");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el equipo : {ex.Message}");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
