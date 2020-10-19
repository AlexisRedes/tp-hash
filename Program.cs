using System;
using System.Collections;

namespace tp4_hash
{
    class Program
    {
        static void Main(string[] args)
        {


            HashTable tabla= new HashTable(33);
            Empleado empleado1= new Empleado("Alexis",21233,43245432);
            Empleado empleado2= new Empleado("Carlos",32344,43267835);
            Empleado empleado3= new Empleado("Juan",12356,67865432);
            Empleado empleado4 = new Empleado("Alberto",12567,43567543);

            ArrayList empleados= new ArrayList();
            empleados.Add(empleado1);empleados.Add(empleado2);empleados.Add(empleado3);empleados.Add(empleado4);
            foreach(Empleado empleado in empleados){
                tabla.agregar(empleado);
            }
            tabla.mostrar();
        }
    }
}
