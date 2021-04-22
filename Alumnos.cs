using System;

namespace AlumnosParcial
{

    class RegistroAlumnos
    {
        public string nombre;

        public string apellido;

        public int matricula; 

        public int edad; 

        public string semestre; 

        public string carrera; 

        public string nombrecompleto
        {
            get => this.nombre + " " + this.apellido;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public float Dividir(float a, int b)
        {
            return a / b;
        }

        public RegistroAlumnos(string nombre, string apellido, int matricula, int edad, string semestre, string carrera)
        {
            this.nombre = nombre;
            this.matricula = matricula;
            this.apellido = apellido; 
            this.edad = edad; 
            this.carrera = carrera;
            this.semestre = semestre; 
        }

        
    }




}