using System;

namespace Lista_Enlazada
{
    public class node
    {
        public int dato;
        public node siguiente;
        public node(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }
    }
}