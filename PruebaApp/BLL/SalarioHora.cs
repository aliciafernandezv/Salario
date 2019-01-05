using PruebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApp.BLL
{
    public class SalarioHora : Salario
    {
        private Empleado empleado;
        static int valorHora = 120;
        static int valorMes = 12;
        public SalarioHora(Empleado empleado)
        {
            this.empleado = empleado;
        }

        
        public double CalculoSalario()
        {
            var result = valorHora * empleado.hourlySalary * valorMes;
            return result;
        }
    }

}
