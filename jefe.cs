using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Jefe : Empleado
    {
        public string autoEmpresa;
        public Jefe() { }
        public Jefe(string nombre, string apellido, string autoEmpresa):base(nombre, apellido)
        {
            this.autoEmpresa = autoEmpresa;
            Console.WriteLine("Se creó el jefe");
        }
        public void Dirigir()
        {
        Console.WriteLine("Estoy dirigiendo la empresa");
        }
    }
}    