using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Estudiante
    {
        public string Nombre { get; set; }
        public string CI { get; set; }
        public string Semestre { get; set; }
        public Estudiante()
        {
            this.Nombre = "Sin nombre";
            this.CI= "Sin CI";
            this.Semestre = "Desconocido";
        }
        public Estudiante(string Nombre, string CI, string Semestre)
        {
            this.Nombre = Nombre;
            this.CI = CI;
            this.Semestre = Semestre;
        }

        public void verDatos()
        {
            Console.WriteLine($"\nNombre:{this.Nombre}" +
                $"\nCI: {this.CI}" +
                $"\nSemestre: {this.Semestre}");
        }
        public void leerDatos()
        {
            Console.WriteLine("Nombre:");
            this.Nombre = Console.ReadLine();
            Console.WriteLine("CI:");
            this.CI= Console.ReadLine();
            Console.WriteLine("Semestre:");
            this.Semestre = Console.ReadLine();
        }
    }
}
