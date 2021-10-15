using System;

namespace Leer_Linea
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Todo lo que se lea mediante la consola es de tipo string u String
            
            //Dato de tipo entero
            Console.WriteLine("Ingrese un numero"); //Mandamos un mensaje en la consola
            int dato = Convert.ToInt32(Console.ReadLine()); //Leemos un dato de tipo int32 Bytes para ello se realiza una convercion
            Console.WriteLine("El dato es de: "+ dato); //Se imprime el valor ingresado
            
            //Dato de tipo Cadena u string leer un todo el caracter
            Console.WriteLine("Ingrese su nombre");
            string nombre = Console.ReadLine(); //Leemos un dato de tipo cadena sin convertir a un tipo numerico
            Console.WriteLine("El nombre de la persona es: "+ nombre);
            
            //Leemos un dato de tipo char
            Console.WriteLine("Ingrese su M F");
            char sexo = Convert.ToChar(Console.Read()); //Leemos un dato de tipo cadena sin convertir a un tipo numerico
            Console.WriteLine("El nombre de la persona es: "+ sexo);

            
        }
    }
}