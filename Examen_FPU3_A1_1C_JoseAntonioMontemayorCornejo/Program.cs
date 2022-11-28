using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Examen_FPU3_A1_1C_JoseAntonioMontemayorCornejo
{
    class Program
    {
        static void Main(string[] args)
        {
            //EN LAS ELECCIONES CONTANDO 5 CANDIDATOS,DETERMINANDO EL NUMERO DE VOTOS POR CANDIDATOS, 
            //LEVAR EL CONTEO Y ESTADISTICAS DE LOS VOTOS,DANDO EL PROCENTAJE DE VOTOS DE CADA CANDIDATO CON RESPECTO AL TOTAL DE
            //LOS VOTANTES, AL NO CONOCER EL NUMERO DE LAS PERSONAS QUE ASISTIRAN AL PROCESO , EL CONTEO SE TERMINARAA AL PRECIONAR 0.


            //Primero que todo declaramos nuestras variables
            bool continuar = true;
            string decicion;
            string titulo = "Votaciones";
            double eleccion,personas,rees;
            double candidato ;
            double Anto = 0, Gusta = 0, issa = 0, mar = 0, cris = 0;
            double totaldevotos, votoscandidatos, porcentaje1, porcentaje2, porcentaje3, porcentaje4, porcentaje5;

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = titulo;
            Console.Clear();

            // utilizanos el ciclo while para que nuestro codigo cuando termine se vuelva a repetir desde esta parte del codigo
            while (continuar)
            {
                //ponemos a los candidatos por los que se puede votar
                Console.WriteLine("Estos son los candidatos por los que puede votar: \n1-Antonio\n2-Gustavo\n3-Issac\n4-Mario\n5-Cristian\no preciona 0 si quieres salir");
                Console.WriteLine("eliga el numero por el candidato que desa votar:");
                candidato = Convert.ToDouble(Console.ReadLine());
                //abrimos varios if para que el usuario puedea seleccionar por el candidato que quiere votar
                if (candidato == 1)
                {
                    Anto = Anto + 1;
                    Console.WriteLine("Usted voto por Antonio, Muchas gracias por votar.");
                }

                if (candidato == 2)
                {
                    Gusta = Gusta + 1;
                    Console.WriteLine("Usted voto por Gustavo, Muchas gracias por votar.");
                }

                if (candidato == 3)
                {
                    issa = issa + 1;
                    Console.WriteLine("Usted voto por Issac, Muchas gracias por votar.");
                }

                if (candidato == 4)
                {
                    mar = mar + 1;
                    Console.WriteLine("Usted voto por Mario, Muchas gracias por votar.");
                }

                if (candidato == 5)
                {
                    cris = cris + 1;
                    Console.WriteLine("Usted voto por Cristian, Muchas gracias por votar.");
                }
                //declaramos este if para que la consola se cierre al precionar 0
                if (candidato == 0)
                {
                    //ponemos thread.sleep para que se ve bonito el codigo cuando esta cerrando
                    Console.WriteLine("cerrando votaciones.");
                    Thread.Sleep(1000);
                    Console.WriteLine("cerrando votaciones..");
                    Thread.Sleep(1000);
                    Console.WriteLine("cerrando votaciones...");
                    Thread.Sleep(1000);
                    Console.WriteLine("cerrando votaciones....");
                    Thread.Sleep(1000);
                    Console.WriteLine("cerrando votaciones.....");
                    Thread.Sleep(1000);
                    return;
                }
                //hacemos la operacion para que nos de el porciento que lleva nuestros candidatos y los votos que llevan
                totaldevotos = (Anto + Gusta + issa + mar + cris);
                porcentaje1 = (100 / totaldevotos) * Anto;
                porcentaje2 = (100 / totaldevotos) * Gusta;
                porcentaje3 = (100 / totaldevotos) * issa;
                porcentaje4 = (100 / totaldevotos) * mar;
                porcentaje5 = (100 / totaldevotos) * cris;

                //preguntamos al usuario para ver si desea salir de la consola
                Console.WriteLine("Que quiere hacer ahora? \n 1-votar denuevo \t 2-ver resultados \t 0-salir");
                eleccion = Convert.ToDouble(Console.ReadLine());
                //aqui ponemos las elecciones
                if (eleccion == 1)
                {
                    Console.Clear();
                }
                if (eleccion == 2)
                {
                    //aqui mostramos los resultados y el porcentaje

                    Console.WriteLine("el candidato Antonio lleva  " + Anto + " votos y lleva el " + porcentaje1+ "%");
                    Console.WriteLine("el candidato Gustavo lleva  " + Gusta + " votos y lleva el " + porcentaje2+"%"); 
                    Console.WriteLine("el candidato Issac lleva    " + issa + " votos y lleva el " + porcentaje3+ "%"); 
                    Console.WriteLine("el candidato Mario lleva    " + mar + " votos y lleva el " + porcentaje4+ "%"); 
                    Console.WriteLine("el candidato Cristian lleva " + cris + " votos y lleva el " + porcentaje5+ "%");
                    Console.WriteLine("en total fueron " + totaldevotos +" votos");

                    Console.WriteLine("¿desea salir del programa?");
                    decicion = Console.ReadLine();
                    if (decicion == "si" || decicion == "Si" || decicion == "SI")
                    {
                        return;
                    }
                    if (decicion == "NO" || decicion == "No" || decicion == "no")
                    {
                        Console.Clear();
                        Console.WriteLine("iniciando");
                    }

                }


                if (eleccion == 0)
                {
                    return;
                }
        }
    }
    }
}











