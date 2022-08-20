using System;

namespace Ejercicios_Semana4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bryan Daniel Escobar Umanzor
            //Carlos Eduardo Mejía Luna
            int elementos;
            Console.Write("Ingrese el número de registros: ");
            elementos = int.Parse(Console.ReadLine());
            string[] nombre = new string[elementos];
            string[] carrera = new string[elementos];
            string[] facultad = new string[elementos];
            int[] edad = new int[elementos];
            string[] email = new string[elementos];
            int[] teléfono = new int[elementos];
            int registro;
            string j;

            for (int i = 0; i < elementos; i++)

            {

                Console.Write("Registro " + i + "\n");

                Console.Write("Ingrese su nombre: ");
                nombre[i] = Console.ReadLine();


                Console.Write("Ingrese su carrera: ");
                carrera[i] = Console.ReadLine();

                Console.Write("Ingrese su facultad: ");
                facultad[i] = Console.ReadLine();

                Console.Write("Ingrese su edad: ");
                edad[i] = int.Parse(Console.ReadLine());

                Console.Write("Ingrese su email: ");
                email[i] = Console.ReadLine();

                Console.Write("Ingrese su teléfono: ");
                teléfono[i] = int.Parse(Console.ReadLine());
            }

            j = "s";
            while (j == "s")
            {
                Console.Write("Ingrese el número de registro que desea consultar: ");
                registro = int.Parse(Console.ReadLine());
                Console.Write("El nombre es: " + nombre[registro] + "\n");
                Console.Write("La carrera es: " + carrera[registro] + "\n");
                Console.Write("La facultad es: " + facultad[registro] + "\n");
                Console.Write("La edad es: " + edad[registro] + "\n");
                Console.Write("El email es: " + email[registro] + "\n");
              
                Console.Write("¿Desea hacer otra consula? Sí o No (S/N): ");
                j = Console.ReadLine();
            }
            Console.Write("¡EJECUCIÓN FINALLIZADA!");
            Console.ReadLine();


        }
    }
}