using System;
using System.Collections.Generic;


namespace AlumnosParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroGrupos registroGrupos = new RegistroGrupos(); 


            RegistroAlumnos resultado = registroGrupos.BucarPorMatricula(2414);
            Console.WriteLine("Este es el Alumno con la Matricula ingresada: ");
            Console.WriteLine("");
            Console.WriteLine(resultado.nombrecompleto + " | " + resultado.edad + " años" +  " | " + "Actualmente cursa en: " + resultado.semestre + " | "  + "En la carrera de: " + resultado.carrera+".");
            
            Console.WriteLine("");

            Console.WriteLine("-----------");

            Console.WriteLine("");

            registroGrupos.MostrarAlumnos(); 

            Console.WriteLine("");

            Console.WriteLine("-----------");

            Console.WriteLine("");


        
            Console.WriteLine("Estas son las carreras con sus respectivos semestres y grupos (Actuales) que el CRESP tiene actualmente:");
            Console.WriteLine("");
        
        
            Dictionary<string,string> ArtesVisuales = new Dictionary<string, string>();
            ArtesVisuales.Add("Artes Visuales1","Primero Semestre"); 
            ArtesVisuales.Add("Artes Visuales2","Segundo Semestre"); 
            ArtesVisuales.Add("Artes Visuales3","Tercero Semestre"); 
            ArtesVisuales.Add("Artes Visuales4","Cuarto Semestre"); 
            ArtesVisuales.Add("Artes Visuales5","Quinto Semestre"); 
            ArtesVisuales.Add("Artes Visuales6","Sexto Semestre"); 
            ArtesVisuales.Add("Artes Visuales7","Septimo Semestre"); 
            ArtesVisuales.Add("Artes Visuales8","Octavo Semestre"); 

            foreach (var key in ArtesVisuales.Keys)
            {
                Console.WriteLine(key + " - " + ArtesVisuales.GetValueOrDefault(key)); 
            }
            

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos2();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos3();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos4(); 
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");



            
            Dictionary<string,string> IngenieriaEnMultimiedia = new Dictionary<string, string>();
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia1","Primero Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia2","Segundo Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia3","Tercero Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia4","Cuarto Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia5","Quinto Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia6","Sexto Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia7","Septimo Semestre"); 
            IngenieriaEnMultimiedia.Add("Ingenierìa en Multimedia8","Octavo Semestre"); 


            foreach (var key in IngenieriaEnMultimiedia.Keys)
            {
                Console.WriteLine(key + " - " + IngenieriaEnMultimiedia.GetValueOrDefault(key)); 
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos5();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos6();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos7();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            registroGrupos.MostrarGrupos8(); 
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");

        

        }
    }
}
