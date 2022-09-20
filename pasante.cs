using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Pasante : Empleado
    {
        protected int horasTrabajo;
        protected int horasEscuela;

        public Pasante() { }
        public Pasante(string nombre, string apellido, int horasTrabajo, int horasEscuela):base(nombre, apellido)
        {
            this.horasTrabajo = horasTrabajo;
            this.horasEscuela = horasEscuela;
            Console.WriteLine("Se creó un pasante");
        }
        public void Aprender()
        {
            Console.WriteLine("Estoy aprendiendo");
        }
    }
}
