using ProyectoFinal.TablaHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Arbol_Avl;

namespace ProyectoFinal.ListaEnlazada
{
    class ListaJugador
    {
        private DataJugadores dato;
        private NodoLista siguiente;

        public ListaJugador(DataJugadores valor, NodoLista siguienteNodo = null)
        {
            dato = valor;
            siguiente = siguienteNodo;
        }

        public ListaJugador()
        {
        }

        public DataJugadores ValorNodo() // Cambiar a PascalCase
        {
            return dato;
        }

        public NodoLista SiguienteNodo() // Cambiar a PascalCase
        {
            return siguiente;
        }

        public void NuevoValor(DataJugadores d) // Cambiar a PascalCase
        {
            dato = d;
        }

        public void SiguienteNodo(NodoLista n) // Cambiar a PascalCase
        {
            siguiente = n;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
