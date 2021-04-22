using System;
using System.Collections.Generic;


namespace AlumnosParcial
{
    class RegistroGrupos
    {
        public List<RegistroAlumnos> GruposALumnos; 
        public List<RegistroAlumnos> ArtesSegundo; 
        public List<RegistroAlumnos> ArtesCuarto; 
        public List<RegistroAlumnos> ArtesSexto; 
        public List<RegistroAlumnos> ArtesOctavo; 
        public List<RegistroAlumnos> IngenieriaMuti2; 
        public List<RegistroAlumnos> IngenieriaMulti4; 
        public List<RegistroAlumnos> IngenieriaMulti6; 
        public List<RegistroAlumnos> IngenieriaMulti8; 

        public RegistroGrupos()
        {
        GruposALumnos = new List<RegistroAlumnos>(); 

        GruposALumnos.Add(new RegistroAlumnos("Adan", " Olivera", 2356 , 17 , "Segundo Semestre" , "Artes Visuales" ));
        GruposALumnos.Add(new RegistroAlumnos("Marco", "Dorado", 2357, 18, "Segundo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Ernesto", "Avila", 2358, 17, "Segundo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Antonio Jesus" ,"Berenguer", 2359, 17, "Segundo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Carlos Javier", "Agudo", 2360, 17, "Segundo Semestre", "Artes Visuales"));

        GruposALumnos.Add(new RegistroAlumnos("Marcel", "Sala", 2401, 20, "Cuarto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Ismael", "Moron", 2402, 19, "Cuarto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Marinol", "Zamora", 2403, 18, "Cuarto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Placido", "Flores", 2404, 21, "Cuarto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Idelfonso", "Moron", 2405, 19, "Cuarto Semestre", "Artes Visuales")); 

        GruposALumnos.Add(new RegistroAlumnos("Juan Miguel", "Madrid", 2406, 22, "Sexto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Jon", "Barrera", 2407, 21, "Sexto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Francisco Antonio", "Mata", 2408, 20, "Sexto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Jose Daniel", "Estevez", 2409, 21, "Sexto Semestre", "Artes Visuales")); 
        GruposALumnos.Add(new RegistroAlumnos("Beñat", "Riera", 2410, 20, "Sexto Semestre", "Artes Visuales")); 

        GruposALumnos.Add(new RegistroAlumnos("Aziz" , "Benavides", 2411, 23, "Octavo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Jose Carlos" , "Iniesta", 2412, 22, "Octavo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Juan Dios" , "Valera", 2413, 21, "Octavo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Hamid" , "Holgado", 2414, 22, "Octavo Semestre", "Artes Visuales"));
        GruposALumnos.Add(new RegistroAlumnos("Jesus Antonio" , "Canovas", 2415, 22, "Octavo Semestre", "Artes Visuales"));

        GruposALumnos.Add(new RegistroAlumnos("Carlos Alberto" ,"Talavera", 2516, 17, "Segundo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Emilio Jose", "Soriano", 2517, 18, "Segundo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Rodrigo", "Aznar",  2518, 16, "Segundo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Hilario", "Checa", 2519, 18, "Segundo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Luis Antonio", "Godoy", 2520, 17, "Segundo Semestre", "Ingenieria en Multimedia"));
        
        GruposALumnos.Add(new RegistroAlumnos("Juan Diego", "Lopez", 2521, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Gael", "Vicente", 2522, 19, "Cuarto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Carlos Manuel", "Zamorano", 2523, 19, "Cuarto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Joseba", "Oliveira", 2524, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Gerardo", "Quezada", 2525, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));

        GruposALumnos.Add(new RegistroAlumnos("Ricardo", "Abad", 2526, 20, "Sexto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Cesareo", "Agudo", 2527, 21, "Sexto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Biel", "Botella", 2528, 20, "Sexto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Eusebio", "Andres", 2529, 19, "Sexto Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Eugenio", "Chacon", 2530, 19, "Sexto Semestre", "Ingenieria en Multimedia"));

        GruposALumnos.Add(new RegistroAlumnos("Aziz", "Redondo", 2531, 22, "Octavo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Hicham", "Corral", 2532, 23, "Octavo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Maximo", "Quevedo", 2533, 23, "Octavo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Felix", "Cruz", 2534, 22, "Octavo Semestre", "Ingenieria en Multimedia"));
        GruposALumnos.Add(new RegistroAlumnos("Hector", "Borja", 2535, 21, "Octavo Semestre", "Ingenieria en Multimedia"));


        ArtesSegundo = new List<RegistroAlumnos>();
        ArtesSegundo.Add(new RegistroAlumnos("Adan", " Olivera", 2356 , 17 , "Segundo Semestre" , "Artes Visuales" ));
        ArtesSegundo.Add(new RegistroAlumnos("Marco", "Dorado", 2357, 18, "Segundo Semestre", "Artes Visuales"));
        ArtesSegundo.Add(new RegistroAlumnos("Ernesto", "Avila", 2358, 17, "Segundo Semestre", "Artes Visuales"));
        ArtesSegundo.Add(new RegistroAlumnos("Antonio Jesus" ,"Berenguer", 2359, 17, "Segundo Semestre", "Artes Visuales"));
        ArtesSegundo.Add(new RegistroAlumnos("Carlos Javier", "Agudo", 2360, 17, "Segundo Semestre", "Artes Visuales")); 

        ArtesCuarto = new List<RegistroAlumnos>();
        ArtesCuarto.Add(new RegistroAlumnos("Marcel", "Sala", 2401, 20, "Cuarto Semestre", "Artes Visuales")); 
        ArtesCuarto.Add(new RegistroAlumnos("Ismael", "Moron", 2402, 19, "Cuarto Semestre", "Artes Visuales")); 
        ArtesCuarto.Add(new RegistroAlumnos("Marinol", "Zamora", 2403, 18, "Cuarto Semestre", "Artes Visuales")); 
        ArtesCuarto.Add(new RegistroAlumnos("Placido", "Flores", 2404, 21, "Cuarto Semestre", "Artes Visuales")); 
        ArtesCuarto.Add(new RegistroAlumnos("Idelfonso", "Moron", 2405, 19, "Cuarto Semestre", "Artes Visuales")); 

        ArtesSexto = new List<RegistroAlumnos>();
        ArtesSexto.Add(new RegistroAlumnos("Juan Miguel", "Madrid", 2406, 22, "Sexto Semestre", "Artes Visuales")); 
        ArtesSexto.Add(new RegistroAlumnos("Jon", "Barrera", 2407, 21, "Sexto Semestre", "Artes Visuales")); 
        ArtesSexto.Add(new RegistroAlumnos("Francisco Antonio", "Mata", 2408, 20, "Sexto Semestre", "Artes Visuales")); 
        ArtesSexto.Add(new RegistroAlumnos("Jose Daniel", "Estevez", 2409, 21, "Sexto Semestre", "Artes Visuales")); 
        ArtesSexto.Add(new RegistroAlumnos("Beñat", "Riera", 2410, 20, "Sexto Semestre", "Artes Visuales")); 

        ArtesOctavo = new List<RegistroAlumnos>();
        ArtesOctavo.Add(new RegistroAlumnos("Aziz" , "Benavides", 2411, 23, "Octavo Semestre", "Artes Visuales"));
        ArtesOctavo.Add(new RegistroAlumnos("Jose Carlos" , "Iniesta", 2412, 22, "Octavo Semestre", "Artes Visuales"));
        ArtesOctavo.Add(new RegistroAlumnos("Juan Dios" , "Valera", 2413, 21, "Octavo Semestre", "Artes Visuales"));
        ArtesOctavo.Add(new RegistroAlumnos("Hamid" , "Holgado", 2414, 22, "Octavo Semestre", "Artes Visuales"));
        ArtesOctavo.Add(new RegistroAlumnos("Jesus Antonio" , "Canovas", 2415, 22, "Octavo Semestre", "Artes Visuales"));

        IngenieriaMuti2 = new List<RegistroAlumnos>();
        IngenieriaMuti2.Add(new RegistroAlumnos("Carlos Alberto" ,"Talavera", 2516, 17, "Segundo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMuti2.Add(new RegistroAlumnos("Emilio Jose", "Soriano", 2517, 18, "Segundo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMuti2.Add(new RegistroAlumnos("Rodrigo", "Aznar",  2518, 16, "Segundo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMuti2.Add(new RegistroAlumnos("Hilario", "Checa", 2519, 18, "Segundo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMuti2.Add(new RegistroAlumnos("Luis Antonio", "Godoy", 2520, 17, "Segundo Semestre", "Ingenieria en Multimedia"));

        IngenieriaMulti4 = new List<RegistroAlumnos>();
        IngenieriaMulti4.Add(new RegistroAlumnos("Juan Diego", "Lopez", 2521, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti4.Add(new RegistroAlumnos("Gael", "Vicente", 2522, 19, "Cuarto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti4.Add(new RegistroAlumnos("Carlos Manuel", "Zamorano", 2523, 19, "Cuarto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti4.Add(new RegistroAlumnos("Joseba", "Oliveira", 2524, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti4.Add(new RegistroAlumnos("Gerardo", "Quezada", 2525, 18, "Cuarto Semestre", "Ingenieria en Multimedia"));
        
        IngenieriaMulti6 = new List<RegistroAlumnos>();
        IngenieriaMulti6.Add(new RegistroAlumnos("Ricardo", "Abad", 2526, 20, "Sexto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti6.Add(new RegistroAlumnos("Cesareo", "Agudo", 2527, 21, "Sexto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti6.Add(new RegistroAlumnos("Biel", "Botella", 2528, 20, "Sexto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti6.Add(new RegistroAlumnos("Eusebio", "Andres", 2529, 19, "Sexto Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti6.Add(new RegistroAlumnos("Eugenio", "Chacon", 2530, 19, "Sexto Semestre", "Ingenieria en Multimedia"));

        IngenieriaMulti8 = new List<RegistroAlumnos>(); 
        IngenieriaMulti8.Add(new RegistroAlumnos("Aziz", "Redondo", 2531, 22, "Octavo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti8.Add(new RegistroAlumnos("Hicham", "Corral", 2532, 23, "Octavo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti8.Add(new RegistroAlumnos("Maximo", "Quevedo", 2533, 23, "Octavo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti8.Add(new RegistroAlumnos("Felix", "Cruz", 2534, 22, "Octavo Semestre", "Ingenieria en Multimedia"));
        IngenieriaMulti8.Add(new RegistroAlumnos("Hector", "Borja", 2535, 21, "Octavo Semestre", "Ingenieria en Multimedia"));









    
        
       }


        public List<RegistroAlumnos> MostrarGrupos()
        {
            Console.WriteLine("Este es el grupo de Segundo Semestre de Artes Visuales: ");
            Console.WriteLine("");
            for (int i = 0; i < ArtesSegundo.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + ArtesSegundo[i].nombrecompleto + " | " + "Matricula: " + ArtesSegundo[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos2()
        {
            Console.WriteLine("Este es el grupo de Cuarto Semestre de Artes Visuales: ");
            Console.WriteLine("");
            for (int i = 0; i < ArtesCuarto.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + ArtesCuarto[i].nombrecompleto + " | " + "Matricula: " + ArtesCuarto[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos3()
        {
            Console.WriteLine("Este es el grupo de Sexto Semestre de Artes Visuales: ");
            Console.WriteLine("");
            for (int i = 0; i < ArtesSexto.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + ArtesSexto[i].nombrecompleto + " | " + "Matricula: " + ArtesSexto[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos4()
        {
            Console.WriteLine("Este es el grupo de Octavo Semestre de Artes Visuales: ");
            Console.WriteLine("");
            for (int i = 0; i < ArtesOctavo.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + ArtesOctavo[i].nombrecompleto + " | " + "Matricula: " + ArtesOctavo[i].matricula);
            }
            return null; 
        }

         public List<RegistroAlumnos> MostrarGrupos5()
        {
            Console.WriteLine("Este es el grupo de Segundo Semestre de Ingenieria en Multimedia: ");
            Console.WriteLine("");
            for (int i = 0; i < IngenieriaMuti2.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + IngenieriaMuti2[i].nombrecompleto + " | " + "Matricula: " + IngenieriaMuti2[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos6()
        {
            Console.WriteLine("Este es el grupo de Cuarto Semestre de Ingenieria en Multimedia: ");
            Console.WriteLine("");
            for (int i = 0; i < IngenieriaMulti4.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + IngenieriaMulti4[i].nombrecompleto + " | " + "Matricula: " + IngenieriaMulti4[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos7()
        {
            Console.WriteLine("Este es el grupo de Sexto Semestre de Ingenieria en Multimedia: ");
            Console.WriteLine("");
            for (int i = 0; i < IngenieriaMulti6.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + IngenieriaMulti6[i].nombrecompleto + " | " + "Matricula: " + IngenieriaMulti6[i].matricula);
            }
            return null; 
        }

        public List<RegistroAlumnos> MostrarGrupos8()
        {
            Console.WriteLine("Este es el grupo de Octavo Semestre de Ingenieria en Multimedia: ");
            Console.WriteLine("");
            for (int i = 0; i < IngenieriaMulti8.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + IngenieriaMulti8[i].nombrecompleto + " | " + "Matricula: " + IngenieriaMulti8[i].matricula);
            }
            return null; 
        }


       public RegistroAlumnos BucarPorMatricula(int matricula)
       {
           for (int i = 0; i < GruposALumnos.Count; i++)
           {
               Console.WriteLine("Buscando Alumno...");
               if (GruposALumnos[i].matricula == matricula)
               {
                   return GruposALumnos[i]; 
               }
           }
           return null;
       }


        public List<RegistroAlumnos> MostrarAlumnos()
        {
            Console.WriteLine("Estos son todos los Alumnos inscritos actualmente en el CRESP: "); 
            Console.WriteLine("");

            for (int i = 0; i < GruposALumnos.Count; i++)
            {
                Console.WriteLine("Nombre Completo: " + GruposALumnos[i].nombrecompleto + " | " + "Carrera: " + GruposALumnos[i].carrera + " | " + "Matricula: " + GruposALumnos[i].matricula + " | " + "Semestre: " + GruposALumnos[i].semestre); 
            }
            // {
            //     return this.GruposALumnos;
            // }
            
            return null;

        }
        // public RegistroAlumnos BuscarPorGrupo(string carrera, string semestre)
        // {
        //  for (int i = 0; i < ArtesSegundo.Count; i++)
        //    {
        //        Console.WriteLine("Buscando Alumno...");
        //        if (ArtesSegundo[i].carrera == carrera & ArtesSegundo[i].semestre ==semestre)
        //        {
        //            Console.WriteLine(ArtesSegundo[i]); 
        //        }
        //    }
        //    return null;
        // }


    }





}