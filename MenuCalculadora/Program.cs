using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PooVueling;

namespace MenuCalculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICalculadora iCalculadora = new Calculadora();
            bool flagEnd = true;

            do{
                var key = MostrarMenu();
                switch(key)
                {
                    case 1:
                        MostrarResultado(key, iCalculadora);
                        break;
                    case 2:
                        MostrarResultado(key, iCalculadora);
                        break;
                    case 3:
                        MostrarResultado(key, iCalculadora);
                        break;
                    case 4:
                        MostrarResultado(key, iCalculadora);
                        break;
                    case 5:
                        flagEnd = false;
                        break;
                }

                Console.WriteLine("para continuar");
                var salir = Console.ReadKey();
                Console.Clear();

            } while (flagEnd);
        }

        public static int MostrarMenu()
        {
            Console.WriteLine("Entra una opcion calculadora \n");
            Console.WriteLine("1.- Suma: ");
            Console.WriteLine("2.- Resta: ");
            Console.WriteLine("3.- Multiplicacion: ");
            Console.WriteLine("4.- Division: ");
            Console.WriteLine("5.- Exit de la calculadora: ");
            var keyPressed = Console.ReadLine();
            return int.Parse(keyPressed);
        }

        public static void MostrarResultado(int key, ICalculadora calcu)
        {
            Console.WriteLine("Entra valor num1: \n");
            var num1 = Console.ReadLine();
            Console.WriteLine("Entra valor num2: \n");
            var num2 = Console.ReadLine();
            var result = 0;
            switch (key)
            {
                case 1:
                    result = calcu.Suma(int.Parse(num1), int.Parse(num2));
                    break;
                case 2:
                    result = calcu.Resta(int.Parse(num1), int.Parse(num2));
                    break;
                case 3:
                    result = calcu.Multiplicacion(int.Parse(num1), int.Parse(num2));
                    break;
                case 4:
                    result = calcu.Division(int.Parse(num1), int.Parse(num2));
                    break;
            }

            Console.WriteLine("Resultado: " + result);
        }

    }

}
