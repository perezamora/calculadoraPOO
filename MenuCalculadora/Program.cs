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
        public enum OpcionMenuType
        {
            cont=0,
            Suma=1,
            Resta=2,    
            Mult=3, 
            Div=4,
            Exit=5,
        };

        static void Main(string[] args)
        {
            // Instanciamos el objeto -> solo uno para el programa.
            ICalculadora iCalculadora = new Calculadora();
            bool flagEnd = true;

            do{
                var key = MostrarMenu();
                
                // Convertimos en enum la opcion escogida
                OpcionMenuType op = (OpcionMenuType)Enum.Parse(typeof(OpcionMenuType), key);

                switch (op)
                {
                    case OpcionMenuType.Suma:
                    case OpcionMenuType.Resta:
                    case OpcionMenuType.Mult:
                    case OpcionMenuType.Div:
                        MostrarResultado(op, iCalculadora);
                        break;
                    case OpcionMenuType.Exit:
                        flagEnd = false;
                        break;
                    default:
                        Console.WriteLine("Opcion no valida .... escoja otra");
                        break;
                }

                // Solo si continuamos en menu
                if (flagEnd)
                {
                    Console.WriteLine("Pulse tecla para continuar ...");
                    var salir = Console.ReadKey();
                }
                
                Console.Clear();

            } while (flagEnd);
        }

        // Mostramos el menu por pantalla opciones operaciones de la Calculadora
        public static String MostrarMenu()
        {
            Console.WriteLine("Entra una opcion calculadora \n");
            Console.WriteLine("1.- Suma: ");
            Console.WriteLine("2.- Resta: ");
            Console.WriteLine("3.- Multiplicacion: ");
            Console.WriteLine("4.- Division: ");
            Console.WriteLine("5.- Exit de la calculadora: ");

            var keyPressed = Console.ReadLine();

            // Obtenemos la clave del enum segun la opcion escogida
            var op = keyPressed != "" ? Enum.GetName(typeof(OpcionMenuType), int.Parse(keyPressed)) : "cont";

            return op;
        }

        // Realizamos la operacion escogida por menu
        // Suma = num1 + num2
        // Resta = num1 - num2
        // Multiplicacion = num1 * num2
        // Division = num1/ num2
        public static void MostrarResultado(OpcionMenuType op, ICalculadora calcu)
        {
            Console.WriteLine("Entra valor num1: ");
            var num1 = Console.ReadLine();
            Console.WriteLine("Entra valor num2: ");
            var num2 = Console.ReadLine();
            var result = 0;
            switch (op)
            {
                case OpcionMenuType.Suma:
                    result = calcu.Suma(int.Parse(num1), int.Parse(num2));
                    break;
                case OpcionMenuType.Resta:
                    result = calcu.Resta(int.Parse(num1), int.Parse(num2));
                    break;
                case OpcionMenuType.Mult:
                    result = calcu.Multiplicacion(int.Parse(num1), int.Parse(num2));
                    break;
                case OpcionMenuType.Div:
                    result = calcu.Division(int.Parse(num1), int.Parse(num2));
                    break;
                default:
                    break;
            }

            Console.WriteLine("Resultado: " + result);
        }

    }

}
