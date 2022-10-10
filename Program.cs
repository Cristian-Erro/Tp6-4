using System;

namespace C_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            Console.Clear();
            int nr1=0;
            int nr2=0;
            //Entradas
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ingrese el primer numero a sumar");
            nr1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero a sumar");
            nr2=Convert.ToInt32(Console.ReadLine());
            
            //Llamo a la funcion en la salida
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("******************************************************");
            Console.WriteLine("*********/El resultado de la suma seria "+Sumar(nr1,nr2)+"/***********");
            Console.WriteLine("******************************************************");
            Console.WriteLine("*******/Presione cualquier tecla para terminar/*******");
            Console.ReadKey();
            Console.ResetColor();
        }
        //Funcion de suma de dos variables int
        static int Sumar(int nr1, int nr2){
          int resultado=(nr1+nr2);
          return resultado;
        }
    }
}
