using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            int minutos;
            int segundos;
            double b;
            double h;
            double area;
            double lado1;
            double lado2;
            double lado3;
            double perimetro;
            double pi = 3.1416;
            double radio;
            double h_cilindro;
            double area_cilindro;
            double volumen_cilindrdo;

            Console.Write("Ejercicio 1" + "\n");

            Console.Write("Ingrese el número de horas: ");
            horas = int.Parse(Console.ReadLine());
            minutos = horas * 60;
            segundos = horas * 3600;
            Console.Write("El equivalente en minutos es de: " + minutos + " minutos " + "\n");
            Console.Write("El equivalente en segundos es de: " + segundos + " segundos ");


            Console.Write("\n" + "Ejercicio 2" + "\n");

            Console.Write("Ingrese la base del triángulo: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del triángulo: ");
            h = double.Parse(Console.ReadLine());
            area = (b * h) / 2;
            Console.Write("El área del triángulo es de: " + area + "\n");

            Console.Write("Ingrese el primer lado del triángulo: ");
            lado1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo lado del triángulo: ");
            lado2 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer del triángulo: ");
            lado3 = double.Parse(Console.ReadLine());
            perimetro = lado1 + lado2 + lado3;
            Console.Write("El perimetro del triángulo es de: " + perimetro);

            Console.Write("\n" + "Ejercicio 3" + "\n");

            Console.Write("Ingrese el radio del cilindro: ");
            radio = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la altura del cilindro: ");
            h_cilindro = double.Parse(Console.ReadLine());
            area_cilindro = 2 * pi * radio * (h_cilindro + radio);
            volumen_cilindrdo = pi * (radio * radio) * h_cilindro;
            Console.Write("El área  del cilindro es de: " + area_cilindro + "\n");
            Console.Write("El volumen  del cilindro es de: " + volumen_cilindrdo + "\n");

            Console.Read();
        }
    }
}