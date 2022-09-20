using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Estudiante
    {
        protected string nombre;
        protected string apellido;
        protected int año;
        protected int nota;
        public Estudiante() { }
        public Estudiante(string nombre, string apellido, int año, int nota)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.año = año;
            this.nota = nota;
            Console.WriteLine("Se creó el estudiante");
        }
        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0}, Apellido: {1}, Año: {2}, Nota: {3}", this.nombre, this.apellido, this.año, this.nota);
        }
        public void Desaprobado()
        {
            if(this.nota < 7)
                Console.WriteLine("El alumno {0} {1} está desaprobado", this.nombre, this.apellido);
        }

        public string GetApellido()
        { 
             return this.apellido;
        }
    }
}
