using System;

namespace ConsoleColor
{
    class Program
    {
        static void Main(string[] args)
        {
            //En esta clase vamos a ver como poner el texto y fondo de un color en c#
            Console.BackgroundColor = System.ConsoleColor.Cyan; //Cambiamos el color de fondo de laterminal
            Console.ForegroundColor = System.ConsoleColor.Red; //Cambiamoe el color a las letras
            Console.WriteLine("Hola");
        }
    }
}