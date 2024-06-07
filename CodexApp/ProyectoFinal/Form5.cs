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

namespace ProyectoFinal
{
    public partial class Form5 : Form
    {
        private string filePath = "..\\..\\Data\\jugadores.csv";
        private ListaJugador jugador = new ListaJugador();
        public Form5()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombrecompleto = Nombre.Text.Trim();
            string edad = Edad.Text.Trim();
            string nacionalidad = Nacionalidad.Text.Trim();
            string clubactual = ClubActual.Text.Trim();
            string temporada = Temporada.Text.Trim();
            string posicionjuego = PosicionJuego.Text.Trim();
            string minutosjugados = MinutosJugados.Text.Trim();
            string goles = Goles.Text.Trim();
            string asistencias = Asistencias.Text.Trim();
            string golespenalti = GolesPenalti.Text.Trim();
            string tarjetaamarilla = TarjetaAmarilla.Text.Trim();
            string tarjetaroja = TarjetaRoja.Text.Trim();
            string numerocamisola = NumeroCamisola.Text.Trim();

            try
            {
                bool nombreExiste = false;

                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] campos = line.Split(';');
                            if (campos.Length > 0 && campos[0].Equals(nombrecompleto, StringComparison.OrdinalIgnoreCase))
                            {
                                nombreExiste = true;
                                break;
                            }
                        }
                    }
                }

                if (!nombreExiste)
                {
                    using (StreamWriter writer = new StreamWriter(filePath, true))
                    {
                        writer.WriteLine($"{nombrecompleto};{edad};{nacionalidad};{clubactual};{temporada};{posicionjuego};{minutosjugados};{goles};{asistencias};{golespenalti};{tarjetaamarilla};{tarjetaroja};{numerocamisola}");
                    }

                    MessageBox.Show("Guardado Exitosamente.");
                }
                else
                {
                    MessageBox.Show("El nombre ya existe en el archivo.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el equipo: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
