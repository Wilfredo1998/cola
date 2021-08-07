using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas
{
    class Cola
    {
        Nodo _inicio;

        public void Encolar(Nodo unNodo)
        {
            if (_inicio == null)
            {
                _inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarUltimo(_inicio);
                aux.siguiente = unNodo;
            }
        }

        private Nodo BuscarUltimo(Nodo unNodo)
        {
            if (unNodo.siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarUltimo(unNodo.siguiente);
            }
        }

        public void Desencolar()
        {
            _inicio = _inicio.siguiente;
        }

        public Nodo Inicio
        {
            get
            {
                return _inicio;
            }
        }



        public bool Vacia()
        {
            return (_inicio == null);
        }

    }
}
