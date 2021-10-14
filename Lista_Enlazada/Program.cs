using System;

namespace Lista_Enlazada
{
    class Linked
    {
        node raiz;
        public Linked()
        {
            this.raiz = null;
        }

        public void Agregar(int dato)
        {
            node newNode = new node(dato);
            if (this.raiz == null)
            {
                this.raiz = newNode;
            }
            else
            {
                this.Buscar(this.raiz, newNode);
            }
        }

        public node Buscar(node node, node newNode)
        {
            if (node.siguiente == null)
            {
                return node.siguiente = newNode;
            }
            else
            {
                return this.Buscar(node.siguiente, newNode);
            }
        }

        public void recorrer(node node)
        {
            while (node!= null)
            {
                Console.WriteLine(node.dato);
                node = node.siguiente;
            }
        }
        static void Main(string[] args)
        {
            Linked lista = new Linked();
            lista.Agregar(2);
            lista.Agregar(1);
            lista.Agregar(9);
            Console.WriteLine(lista);
            lista.recorrer(lista.raiz);
        }
    }
}