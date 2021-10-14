using System;

namespace Tipos_Datos_Numerico
{
    class tipos
    {
        //ENTEROS
        sbyte byte1=120; //Dato de tipo shrot byte
        byte byte2 = 120; //Dato tipo numerico entero
        int entero = 190; //Dato de tipo entero
        long grande = 1222222222; //Dato de tipo entero long
        //PUNTO DECIMAL
        float flotante = 23.23f; //Dato de tipo flotante
        double doble = 12.345; //Dato de tipo double
        
        
        //Metodo constructor
        public tipos()
        {
            
        }

        public void SetEntero(int entero)
        {
            //Hacemos referencia local a la variable de la clase
            this.entero = entero;
        }
        
        //Metodo main el metodo de parida
        public static void Main(string[] args)
        {
            tipos objeto = new tipos();
            objeto.SetEntero(4);
            Console.WriteLine(objeto.entero);
            //Concatenacion con texto igual al lenguaje de java
            Console.WriteLine("Dato de tipo entero "+objeto.entero);
        }
    }
}