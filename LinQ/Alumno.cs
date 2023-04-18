using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    class Alumno
    {
        public int ci = 0;
        public string nombre = " ";
        public int notaA = 0;
        public int notaP = 0;
        public int notaEx = 0;
        public Alumno(int ci, string nombre, int notaA, int notaP, int notaEx)
        {
            this.ci = ci;
            this.nombre = nombre;
            this.notaA = notaA;
            this.notaP = notaP;
            this.notaEx = notaEx;
        }
        public void verDatos()
        {
            Console.WriteLine($"\nDatos:" +
                $"\nNombre: {this.nombre}" +
                $"\nNotaA: {this.notaA}" +
                $"\nNotaP: {this.notaP}" +
                $"\nNotaEx: {this.notaEx}");
        }
    }
}
