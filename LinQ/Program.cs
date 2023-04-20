using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] nombres = { "Elver", "Monica ", "Benito", "Alex", "Marcelo" };
            var Consulta1 = from nom in nombres
                            orderby nom ascending
                            select nom;
            foreach (var item in Consulta1)
            {
                Console.WriteLine(item);
            }
            */
            List<string> miLista = new List<string>()
        {
            "Saludos a todos",
            "los estudiantes de ISI",
            "de la Univalle",
            "Hoy vimos la pelicula."
        };
            //CONSULTA #1
            var query1 = from cad in miLista
                        where (cad.Contains(" la "))
                        select cad;
            //RESULTADO #1
            Console.WriteLine("CONSULTA 1");
            foreach (var item in query1)
            {
                Console.WriteLine(item);
            }

            //CONSULTA #2
            List<string> query2 = (from cad in miLista select cad).ToList();

            //RESULTADO #
            Console.WriteLine("\nCONSULTA 2");
            foreach (var item in query2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Reyes Ortiz Chacon Alejandro");

            Estudiante est = new Estudiante("Alejandro", "538764", "5to");
            Estudiante est2 = new Estudiante("Belen", "36646", "5to");
            Estudiante est3 = new Estudiante("Jose", "538764", "3ro");
            Estudiante est4 = new Estudiante("Pedro", "844653", "2do");
            Estudiante est5 = new Estudiante("Jesus", "67124", "4to");

            Estudiante[] vecEstudiante = new Estudiante[] { est, est2, est3, est4, est5 };

            Estudiante[] vectorEstudiantes = new Estudiante[]
            {
                new Estudiante("Alejandro", "538764", "5to"),
                new Estudiante("Belen", "36646", "5to"),
                new Estudiante("Jose", "538764", "3ro"),
                new Estudiante("Pedro", "844653", "2do"),
                new Estudiante("Jesus", "67124", "4to")
            };

            var queryEstudiantes = from estudiante in vectorEstudiantes
                                    where estudiante.Nombre.Length == 5
                                    select estudiante.Nombre;

            // Imprimir los datos de los estudiantes encontrados
            foreach (var estudiante in queryEstudiantes)
            {
                Console.WriteLine(estudiante);
                //estudiante.verDatos();
            }
            //CONSULTA ALUMNO
            Console.WriteLine("\nLISTADO de los objetos de la lista:\n");
            List<Alumno> listAlumnos = new List<Alumno>()
            {
                new Alumno (17654, "Ana Lisa", 10, 35, 50),
                new Alumno (74590, "Luis", 15, 35, 50),
                new Alumno (86535, "Jorge", 8, 35, 50)
            };

            List<Alumno> queryAlumnos = (from alum in listAlumnos
                                        select alum).ToList();
            foreach (Alumno alum in queryAlumnos)
            {
                alum.verDatos();
            }
            foreach (var alum in queryAlumnos)
            {
                Console.WriteLine(alum);
            }
            //PROBLEMA 1
            Console.WriteLine("\nNOTAS mayores a 50:\n");
            List<Alumno> queryAlumnos2 = (from alum2 in listAlumnos
                                        where (alum2.notaA + alum2.notaP + alum2.notaEx) >50
                                        select alum2).ToList();
            foreach (Alumno alum in queryAlumnos2)
            {
                alum.verDatos();
            }
            //PROBLEMA 2
            Console.WriteLine("\nNombres que contengan A:\n");
            
            List<Alumno> queryAlumnos3 = (from alum2 in listAlumnos
                                        where (alum2.nombre.Contains("a"))
                                        select alum2).ToList();
            foreach (Alumno alum in queryAlumnos3)
            {
                alum.verDatos();
            }
            //CONSULTA nombres de los estudiantes cuya nota de asistencia este entre 10 y 15
            Console.WriteLine("\n NOTA Asistencia entre 10 y 15");
            List<Alumno> queryAlumnos4 = (from alum2 in listAlumnos
                                        where (alum2.notaA >= 10 && alum2.notaA <= 15)
                                        select alum2).ToList();
            foreach (Alumno alumno in queryAlumnos4)
            {
                alumno.verDatos();
            }
            Console.Write("Reyes Ortiz Chacon Alejandro");
        }
    }
}