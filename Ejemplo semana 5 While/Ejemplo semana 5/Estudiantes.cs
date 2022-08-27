using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{

    class Estudiantes
    {
        private int id;
        private String código;
        private String nombre;
        private int edad;
        private String facultad;
        private String carrera;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public String Código
        {
            get { return código; }
            set { código = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Facultad
        {
            get { return facultad; }
            set { facultad = value; }
        }

        public String Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }


        public Estudiantes(int id, String código, string nombre, int edad, String facultad ,String carrera)
        {
            this.id = id;
            this.código = código;
            this.nombre = nombre;
            this.edad = edad;
            this.facultad = facultad;
            this.carrera = carrera;

        }

        public string mostrar()
        
        {
            
            return "+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n" + " id: " + id + "\n codigo: " + código + "\n nombre: " + nombre + "\n edad: " + edad + "\n facultad: " + facultad + "\n carrera: " + carrera + "\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+\n";
           
        }
    }

}
