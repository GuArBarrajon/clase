using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Empleado
    {
        protected string nombre;
        protected string apellido;

        public Empleado() { }
        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            Console.WriteLine("Empleado creado");
        }
        public void Mostrar()   
        {
            Console.WriteLine("Nombre: {0}, Apellido: {1}", this.nombre, this.apellido);
        }
    
        public void Trabajar()
        {
            Console.WriteLine("Estoy trabajando");
        }
        public void Descansar()
        {
            Console.WriteLine("Estoy descansando");
        }
    }
}
