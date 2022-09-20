using Ejercicio2;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

List<Estudiante> listaAlumnos = new List<Estudiante>();
int opcion = 0;
while (opcion != 5)
{
    Console.WriteLine("Menú:");
    Console.WriteLine("1. Cargar estudiante");
    Console.WriteLine("2. Mostrar lista de estudiantes");
    Console.WriteLine("3. Mostrar desaprobados");
    Console.WriteLine("4. Borrar estudiante");
    Console.WriteLine("5. Salir del Menú");
    Console.Write("Ingrese una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    switch (opcion)
    {
        case 1: 
            string nombre, apellido;
            int año, nota;
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese el año: ");
            año = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la nota: ");
            nota = Convert.ToInt32(Console.ReadLine());
            listaAlumnos.Add(new Estudiante(nombre, apellido, año, nota));
            break;

        case 2:
            Console.WriteLine("Lista de estudiantes");
            foreach (Estudiante estu in listaAlumnos)
                estu.Mostrar();
            break;

        case 3:
            Console.WriteLine("Estudiantes desaprobados");
            foreach(Estudiante estu in listaAlumnos)
                estu.Desaprobado();
            break;

        case 4:
            string apell;
            char eleccion;
            Console.WriteLine("Ingrese el apellido del alumno que desea borrar: ");
            apell = Console.ReadLine();
            foreach (Estudiante estu in listaAlumnos)
            {
                if (estu.GetApellido() == apell)
                {
                    estu.Mostrar();
                    Console.Write("Está seguro que quiere borrarlo (s/n): ");
                    eleccion = Convert.ToChar(Console.ReadLine());
                    if (eleccion == 's')
                    {
                        listaAlumnos.Remove(estu);
                        Console.WriteLine("Alumno Borrado");
                        break;
                    }
                }
            }
            break;

        case 5: Console.WriteLine("Gracias por utilizar el programa");
            break;
    }
}
