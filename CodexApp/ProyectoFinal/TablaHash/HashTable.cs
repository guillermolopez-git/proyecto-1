using ProyectoFinal.ListaEnlazada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProyectoFinal.TablaHash
{
    class HashTable
    {
        private const int Tamano = 100;
        private LinkedList<Partidos>[] tabla;

        public HashTable()
        {
            tabla = new LinkedList<Partidos>[Tamano];
            for (int i = 0; i < Tamano; i++)
            {
                tabla[i] = new LinkedList<Partidos>();
            }
        }

        private int Hash(string key)
        {
            int hashValue = 0;
            foreach (char c in key)
            {
                hashValue += (int)c;
            }
            return hashValue % Tamano;
        }

        public void AgregarPartido(string dateGMT, int attendance, string homeTeamName, string awayTeamName, string referee, int homeTeamGoalCount, int awayTeamGoalCount, double homeTeamPossession, double awayTeamPossession, string stadiumName)
        {
            Partidos nuevoPartido = new Partidos(dateGMT, attendance, homeTeamName, awayTeamName, referee, homeTeamGoalCount, awayTeamGoalCount, homeTeamPossession, awayTeamPossession, stadiumName);
            int index = Hash(homeTeamName);
            tabla[index].AddLast(nuevoPartido);
        }

        public Partidos BuscarPartido(string homeTeamName)
        {
            int index = Hash(homeTeamName);
            foreach (Partidos partido in tabla[index])
            {
                if (partido.Home_Team_Name == homeTeamName)
                {
                    return partido;
                }
            }
            return null;
        }

        public void ModificarPartido(string homeTeamName, Partidos partidoModificado)
        {
            int index = Hash(homeTeamName);
            var nodo = tabla[index].First;
            while (nodo != null)
            {
                if (nodo.Value.Home_Team_Name == homeTeamName)
                {
                    nodo.Value = partidoModificado;
                    return;
                }
                nodo = nodo.Next;
            }
        }

        public void EliminarPartido(string homeTeamName)
        {
            int index = Hash(homeTeamName);
            var nodo = tabla[index].First;
            while (nodo != null)
            {
                if (nodo.Value.Home_Team_Name == homeTeamName)
                {
                    tabla[index].Remove(nodo);
                    return;
                }
                nodo = nodo.Next;
            }
        }

        public List<Partidos> ObtenerTodosPartidos()
        {
            List<Partidos> partidos = new List<Partidos>();
            foreach (var lista in tabla)
            {
                foreach (var partido in lista)
                {
                    partidos.Add(partido);
                }
            }
            return partidos;
        }

    }
}