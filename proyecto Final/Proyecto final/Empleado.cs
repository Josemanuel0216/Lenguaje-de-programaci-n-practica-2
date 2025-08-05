using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    public class Empleado
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Cargo { get; set; }
        public DateTime FechaInicio { get; set; }
        public decimal Salario { get; set; }
        public string Estado { get; set; }



        public string TiempoEmpresa => obtenerTiempo();
        private string obtenerTiempo()

        {
            
           
            var hoy = DateTime.Today;
            var tiempo = hoy - FechaInicio;
            int anos = (int)(tiempo.Days / 365.25);
            int meses = (int)((tiempo.Days % 365.25) / 30);
            return $"{anos} year , {meses} months";
            
        }

        public decimal AFP => Salario * 0.0287m;
        public decimal ARS => Salario * 0.0304m;
        public decimal ISR => ObtenerISR(Salario);


        public decimal ObtenerISR(decimal salario)
        {
            decimal anual = salario * 12;

            if (anual <= 416220)
                return 0;
            else if (anual <= 624329)
                return ((anual - 416220) * 0.15m) / 12;
            else if (anual <= 867123)
                return ((anual - 624329) * 0.20m + 31205) / 12;
            else
                return ((anual - 867123) * 0.25m + 79776) / 12;
        }
    }
}
