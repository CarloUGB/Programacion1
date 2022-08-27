using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luis Antonio Barrera Zelaya SMSS010722
            // Erick Fernando Mayen Castillo SMSS024722
            // Carlos Eduardo Mejía Luna SMSS061022
            // Bryan Daniel Escobar Umanzaor SMSS045722
            // Ambar Carolina Coreas Aguilar SMSS020822

            int Id;
            String Código;
            String Nombre;
            String Facultad;
            String Carrera;
            int Edad;
            String control = "si";
            int índice = 0;
            int i = 0;
            String n = "";
            int Numero = 0;
            String otra = "si";
            String opcion = "";

            Estudiantes[] arregloestudiantes = new Estudiantes[1];


            while (control == "si")
            {
                Console.WriteLine("Ingrese los siguientes datos:");
                Id = i++;
                Console.WriteLine("Ingrese el Código:");
                Código = Console.ReadLine();

                Console.WriteLine("Ingrese el Nombre:");
                Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la edad:");
                Edad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la facultad:");
                Facultad = Console.ReadLine();

                Console.WriteLine("Ingrese la carrera:");
                Carrera = Console.ReadLine();

                arregloestudiantes[índice] = new Estudiantes(Id, Código, Nombre, Edad, Facultad, Carrera);

                Console.WriteLine("Desea agregar otro registro (si, No): ");
                control = Console.ReadLine();
                if (control == "si")
                { índice = índice + 1;
                    Array.Resize(ref arregloestudiantes, arregloestudiantes.Length + 1);

                }
                else { control = "No"; }
            }

            while (otra == "si")

                
            {
                Console.Write("------------------------------------------------------------------\n");

                Console.WriteLine("¿cual filtro quiere aplicar? (facultad)(carrera)(edad)");
                control = Console.ReadLine();

                if (control == "facultad")
                {

                    Console.WriteLine("¿cual facultad quiere filtrar? ");
                    n = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Facultad == n
                                                                   select estudiante;

                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }
                }

                if (control == "carrera")
                {
                    Console.WriteLine("¿cual Carrera quiere filtrar?");
                    n = Console.ReadLine();

                    IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                   where estudiante.Carrera == n
                                                                   select estudiante;

                    Console.WriteLine("El resultado de la consulta es:");
                    foreach (Estudiantes consulta in consultaestudiantes)
                    {
                        Console.WriteLine(consulta.mostrar());

                    }
                }

                if (control == "edad")

                {
                    Console.WriteLine("¿de que edad quiere filtrar?");
                    Numero = int.Parse(Console.ReadLine());

                    Console.WriteLine("¿de que rango? (mayor)(menor)(igual)");
                    opcion = Console.ReadLine();

                    if (opcion == "menor")
                    {
                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.Edad < Numero
                                                                       select estudiante;

                        Console.WriteLine("El resultado de la consulta es:");
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }

                    if (opcion == "mayor")
                    {
                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.Edad > Numero
                                                                       select estudiante;

                        Console.WriteLine("El resultado de la consulta es:");
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }

                    if (opcion == "igual")
                    {
                        IEnumerable<Estudiantes> consultaestudiantes = from estudiante in arregloestudiantes
                                                                       where estudiante.Edad == Numero
                                                                       select estudiante;

                        Console.WriteLine("El resultado de la consulta es:");
                        foreach (Estudiantes consulta in consultaestudiantes)
                        {
                            Console.WriteLine(consulta.mostrar());

                        }
                    }

                }

                else
                {
                    Console.WriteLine("no se encontro ningun resultado");
                }

                Console.WriteLine("¿quiere realizar una nueva consulta?si,no");
                otra = Console.ReadLine();
            }

            Console.Read();

        }
    }
}
