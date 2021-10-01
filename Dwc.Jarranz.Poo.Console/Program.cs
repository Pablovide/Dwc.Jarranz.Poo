using System;
using System.Linq;

using System.Collections.Generic;

namespace Dwc.Jarranz.Poo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
        

            EscribirCabecera("CUADRADO:");
            var ladoCuadrado = LeerEnteroConsola(
                "Inserte la longitud de los lados",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);

            EscribirCabecera("RECTANGULO:");
            var ladoRectangulo1 = LeerEnteroConsola(
                "Inserte la longitud del lado 1",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);
            var ladoRectangulo2 = LeerEnteroConsola(
                "Inserte la longitud del lado 2",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);

            EscribirCabecera("ROMBO:");
            var ladoRombo = LeerEnteroConsola(
                "Inserte la longitud de los lados",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);
            var anguloRombo = LeerEnteroConsola(
                "Inserte uno de los dos angulos que forma los lados",
                "El valor tiene que ser mayor de 0 y menor de 180",
                "grados",
                (i) => i > 0 && i < 180);

            EscribirCabecera("ROMBOIDE:");
            var ladoRomboide1 = LeerEnteroConsola(
                "Inserte la longitud del lado 1",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);
            var ladoRomboide2 = LeerEnteroConsola(
                "Inserte la longitud del lado 2",
                "El valor tiene que ser mayor de 0",
                "cm",
                (i) => i > 0);
            var anguloRomboide = LeerEnteroConsola(
                "Inserte uno de los dos angulos que forman los lados",
                "El valor tiene que ser mayor de 0 y menor de 180",
                "grados",
                (i) => i > 0 && i < 180);

           
            System.Console.Clear();
            
            //TODO: Mostrar resumen de las figuras tal y como se detalla en el ejercicio

            System.Console.ReadLine();
        }


        private static int LeerEnteroConsola(string mensaje, string mensajeValidacion, string unidad, Func<int, bool> predicate)
        {
            int result;
            bool parsed;
            bool valid;


            List<int> a = new List<int>();

            System.Console.WriteLine($"\t{mensaje}");
            do
            {

                parsed = false;
                valid = false;
                var line = System.Console.ReadLine();
                System.Console.SetCursorPosition(0, System.Console.CursorTop - 1);
                System.Console.WriteLine(string.Empty.PadRight(line.Length, ' '));
                System.Console.SetCursorPosition(0, System.Console.CursorTop - 1);
                parsed = int.TryParse(line, out result);
                if (!parsed)
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("\tEl valor debe ser un entero.");
                    System.Console.ResetColor();
                }
                else
                {
                    valid = predicate(result);
                }

                if (parsed && !valid)
                {
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine($"\t{mensajeValidacion}");
                    System.Console.ResetColor();
                }
            } while (!parsed || !valid);

            System.Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine($"\t{result} {unidad}");
            System.Console.ResetColor();

            return result;
        }

        private static void EscribirCabecera(string cabecera)
        {
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine(cabecera);
            System.Console.ResetColor();
        }
    }
}
