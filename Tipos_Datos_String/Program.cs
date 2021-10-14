using System;

namespace Tipos_Datos_String
{
    class Program
    {
        //Datos de tipo String
        String nombre = "Edgar Ivan Lorenzo Villalobos";
        
        static void Main(string[] args)
        {
            //Ceracion instancia de la clase
            Program cadena = new Program();
            //Convertimos el dato de tipo String a una cadena
            string[] arreglo = cadena.nombre.Split(" ");
            
            //foreach en c# en vez de llevar los dos puntos lleva la palabra in
            foreach (string v in arreglo)
            {
                //Se imprime el valor por cada iteracion
                Console.WriteLine(v);
            }
            
            //Metodo replace para reemplazar un dato por otro
            Console.WriteLine(cadena.nombre.Replace("Edgar","edgar"));
        }
    }
}