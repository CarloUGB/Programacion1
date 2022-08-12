using System;

namespace Ejercicios_Semana3
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

            double valor_1;
            double valor_2;
            double suma;
            double resta;
            double multiplicacion;
            double division;

            string nombre;
            int edad;
            double peso;
            double estatura;
            string tipo_de_sangre;

            int opcion;
            string min_seg;
            int veces;
            int continuar;


            Console.Write("¿Desea continuar con los ejercicios? 1 para sí 2 para no: ");
            continuar = int.Parse(Console.ReadLine());
            while (continuar == 1)
            {



                Console.Write("Ingrese que ejercicio desea visualizar (número del 1-5): ");
                Console.Write("\n" + "Ejercicio 1: " + "\n");
                Console.Write("Ejercicio 2: " + "\n");
                Console.Write("Ejercicio 3: " + "\n");
                Console.Write("Ejercicio 4: " + "\n");
                Console.Write("Ejercicio 5: " + "\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:

                        Console.Write("Ejercicio 1" + "\n");

                        Console.Write("Ingrese el número de horas: " + "\n");
                        horas = int.Parse(Console.ReadLine());
                        minutos = horas * 60;
                        segundos = horas * 3600;
                        Console.Write("¿Desea ver el resultado en minutos o segundos?: " + "\n");
                        min_seg = Console.ReadLine();
                        switch (min_seg)
                        {
                            case "minutos":
                                Console.Write("El equivalente en minutos es de: " + minutos + " minutos " + "\n");
                                break;

                            case "segundos":
                                Console.Write("El equivalente en segundos es de: " + segundos + " segundos ");
                                break;
                        }
                        break;

                    case 2:


                        Console.Write("\n" + "Ejercicio 2" + "\n");

                        Console.Write("¿Cuantas veces desea sacar el área y el perimetro?: " + "\n");
                        veces = int.Parse(Console.ReadLine());
                        for (int contador = 1; contador == veces; contador++)
                        {
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
                            Console.Write("El perimetro del triángulo es de: " + perimetro + "\n");

                        }
                        break;

                    case 3:


                        Console.Write("\n" + "Ejercicio 3" + "\n");

                        Console.Write("Ingrese el radio del cilindro: ");
                        radio = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la altura del cilindro: ");
                        h_cilindro = double.Parse(Console.ReadLine());
                        area_cilindro = 2 * pi * radio * (h_cilindro + radio);
                        volumen_cilindrdo = pi * (radio * radio) * h_cilindro;
                        Console.Write("El área  del cilindro es de: " + area_cilindro + "\n");
                        Console.Write("El volumen  del cilindro es de: " + volumen_cilindrdo + "\n");

                        break;

                    case 4:

                        Console.Write("\n" + "Ejercicio 4" + "\n");

                        Console.Write("Vamos a sumar" + "\n");
                        Console.Write("Ingrese el primer valor: ");
                        valor_1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo valor: ");
                        valor_2 = double.Parse(Console.ReadLine());
                        suma = valor_1 + valor_2;
                        Console.Write("La respuesta es:" + suma);

                        Console.Write("\n" + "Vamos a restar" + "\n");
                        Console.Write("Ingrese el primer valor: ");
                        valor_1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo valor: ");
                        valor_2 = double.Parse(Console.ReadLine());
                        resta = valor_1 - valor_2;
                        Console.Write("La respuesta es:" + resta);

                        Console.Write("\n" + "Vamos a multiplicar" + "\n");
                        Console.Write("Ingrese el primer valor: ");
                        valor_1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo valor: ");
                        valor_2 = double.Parse(Console.ReadLine());
                        multiplicacion = valor_1 * valor_2;
                        Console.Write("La respuesta es:" + multiplicacion);

                        Console.Write("\n" + "Vamos a dividir" + "\n");
                        Console.Write("Ingrese el primer valor: ");
                        valor_1 = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese el segundo valor: ");
                        valor_2 = double.Parse(Console.ReadLine());
                        division = valor_1 / valor_2;
                        Console.Write("La respuesta es:" + division);


                        break;

                    case 5:

                        Console.Write("\n" + "Ejercicio 5" + "\n");

                        Console.Write("Sistema de FOSALUD" + "\n");
                        Console.Write("Ingrese los datos del paciente" + "\n");
                        Console.Write("Nombre: ");
                        nombre = Console.ReadLine();
                        Console.Write("Edad: ");
                        edad = int.Parse(Console.ReadLine());
                        Console.Write("Peso(Kg): ");
                        peso = double.Parse(Console.ReadLine());
                        Console.Write("Estatura(m): ");
                        estatura = double.Parse(Console.ReadLine());
                        Console.Write("Tipo de sangre: ");
                        tipo_de_sangre = Console.ReadLine();


                        Console.Write("\n" + "LOS DATOS DEL PACIENTE SON:" + "\n");
                        Console.Write("Nombre: " + nombre + "\n");
                        Console.Write("Edad: " + edad + "\n");
                        Console.Write("Peso: " + peso + " kg" + "\n");
                        Console.Write("Estatura: " + estatura + " m" + "\n");
                        Console.Write("Tipo de sangre: " + tipo_de_sangre + "\n");

                        break;

                }
                Console.Write("\n"+"¿Desea continuar con los ejercicios? 1 para sí 2 para no: ");
                continuar = int.Parse(Console.ReadLine());
            }
            Console.Read();
            {
                
            }
        
        }
    }
}
