using ProyectoFinal.TablaHash;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoFinal.ListaEnlazada
{
    class NodoLista
    {
        public object dato; // jugador
        public NodoLista siguiente; // siguiente nodo

   
        public NodoLista(object valor)
        {
            dato = valor;
            siguiente = null;
        }

        // Constructor que recibe un valor y el siguiente nodo
        public NodoLista(object valor, NodoLista siguienteNodo)
        {
            dato = valor;
            siguiente = siguienteNodo;
        }

        // Operaciones de acceso
        public object ValorNodo()
        {
            return dato;
        }

        public NodoLista SiguienteNodo() // Corrección de nombre
        {
            return siguiente;
        }

        // Métodos para modificar el nodo
        public void NuevoValor(object d)
        {
            dato = d;
        }

        public void SiguienteNodo(NodoLista n) // Corrección de nombre
        {
            siguiente = n;
        }

        public string Visitar()
        {
            return dato.ToString();
        }
    }
}
