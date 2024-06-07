using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.TablaHash
{
    public class MiListaEnlazada<T>
    {
       
            public class Nodo
            {
                public T Valor { get; set; }
                public Nodo Siguiente { get; set; }

                public Nodo(T valor)
                {
                    Valor = valor;
                    Siguiente = null;
                }
            }

            public Nodo cabeza;

            public void AddLast(T valor)
            {
                if (cabeza == null)
                {
                    cabeza = new Nodo(valor);
                }
                else
                {
                    Nodo ultimo = ObtenerUltimoNodo();
                    ultimo.Siguiente = new Nodo(valor);
                }
            }

            public void Remove(Nodo nodoAnterior, Nodo nodoActual)
            {
                if (nodoAnterior == null)
                {
                    cabeza = nodoActual.Siguiente;
                }
                else
                {
                    nodoAnterior.Siguiente = nodoActual.Siguiente;
                }
            }

            public IEnumerator<T> GetEnumerator()
            {
                Nodo nodoActual = cabeza;
                while (nodoActual != null)
                {
                    yield return nodoActual.Valor;
                    nodoActual = nodoActual.Siguiente;
                }
            }

            public Nodo ObtenerUltimoNodo()
            {
                Nodo nodoActual = cabeza;
                while (nodoActual.Siguiente != null)
                {
                    nodoActual = nodoActual.Siguiente;
                }
                return nodoActual;
            }
     }
}

