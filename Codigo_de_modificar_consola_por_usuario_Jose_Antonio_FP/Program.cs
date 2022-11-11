using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Codigo_de_modificar_consola_por_usuario_Jose_Antonio_FP
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo = "Modifcacion_de_Consola"; ;
            int contraseña;
            int modificar, color, colorletra, tamaño, usuario;
           
            

            Console.Title = titulo;
            Console.Clear();

            
            
            Console.WriteLine("Escriba su usuario (matricula) :");
            usuario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba su contraseña(solo numeros):");
            contraseña = Convert.ToInt32(Console.ReadLine());

            if (usuario == 221000117)
            {

            }
            else
            {
                Console.WriteLine("eqivocado");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo.");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo..");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo...");
                Thread.Sleep(1000);
                return;
            }
            if (contraseña==18204)
            {
              
            }
            else
            {
                Console.WriteLine("eqivocado");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo.");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo..");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo...");
                Thread.Sleep(1000);
                return;
            }
            Console.WriteLine("Escribe 1 si quieres modificar la consola, Escribe 2 si no la quieres modificar:");
            modificar = Convert.ToInt32(Console.ReadLine());

            if (modificar == 1)
            {
                Console.WriteLine("eliga un numero para el color que quiere la consola, 1:azul, 2:verde, 3:amarilla, 4:rojo, 5:blanca, 6:Negro");
                color = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ok, Espere un poco");
                Thread.Sleep(1000);
                Console.WriteLine("cambiando.");
                Thread.Sleep(1000);
                Console.WriteLine("cambiando..");
                Thread.Sleep(1000);
                Console.WriteLine("cambiando...");
                Thread.Sleep(1000);
                Console.WriteLine("cambiando....");
                Thread.Sleep(1000);
                if (color == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Clear();
                }
                if (color == 2)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Clear();
                }
                if (color == 3)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                }
                if (color == 4)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Clear();
                }
                if (color == 5)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                }
                if (color == 6)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine("Ok, adios");
                Console.WriteLine("saliendo.");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo..");
                Thread.Sleep(1000);
                Console.WriteLine("saliendo...");
                Thread.Sleep(1000);
            }

            Console.WriteLine("eliga un numero para el color que quiere las letras de la consola, 1:azul, 2:verde, 3:amarilla, 4:rojo, 5:blanca, 6:negro");
            colorletra = Convert.ToInt32(Console.ReadLine());
            if (colorletra == 1)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Clear();
            }
            if (colorletra == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
            }
            if (colorletra == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
            }
            if (colorletra == 4)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            if (colorletra == 5)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            if (colorletra == 6)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
            }

            Console.WriteLine("ahora elige el tamaño de la pantalla, 1:pequeña, 2:mediana, 3:grande, 4:toda la pantalla");
            tamaño = Convert.ToInt32(Console.ReadLine());
            if (tamaño == 1)
            {
                Console.SetWindowSize(60, 20);
            }
            if (tamaño == 2)
            {
                Console.SetWindowSize(120, 40);
            }
            if (tamaño == 3)
            {
                Console.SetWindowSize(180, 60);
            }
            if (tamaño == 4)
            {
                Console.SetWindowSize(240, 63);
            }

            Console.WriteLine("Esta listote bro");
            Thread.Sleep(1000);
            Console.WriteLine("prueba.");
            Thread.Sleep(1000);
            Console.WriteLine("prueba..");
            Thread.Sleep(1000);
            Console.WriteLine("prueba...");
            Thread.Sleep(1000);
            Console.WriteLine("prueba....");
            Thread.Sleep(1000);
            Console.ReadKey();
        }
    }
}
