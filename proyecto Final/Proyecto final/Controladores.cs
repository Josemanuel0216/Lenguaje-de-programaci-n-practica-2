using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SistemaEmpleados
{
    class Controladores
    {

        public static List<Empleado> empleados = new List<Empleado>();

        public static bool AgregarEmpleado(Empleado emp)
        {
            if (empleados.Any(e => e.ID == emp.ID))
                return false;

            empleados.Add(emp);
            return true;
        }

        public static bool ActualizarEmpleado(string id, Empleado actualizado)
        {
            var index = empleados.FindIndex(e => e.ID == id);
            if (index == -1)
                return false;
            empleados[index] = actualizado;
            return true;
        }

        public static bool EliminarEmpleado(string id)
        {
            var emp = empleados.FirstOrDefault(e => e.ID == id);
            if (emp == null) return false;
            empleados.Remove(emp);
            return true;
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }


    }
}
