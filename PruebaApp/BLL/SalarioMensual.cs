using PruebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApp.BLL
{
    public class SalarioMensual: Salario
    {
        private Empleado empleado;
        static int valorMes = 12;
        public SalarioMensual(Empleado empleado)
        {
            this.empleado = empleado;
        }
        public double CalculoSalario()
        {
            var result = empleado.monthlySalary * valorMes;
            return result;
        }
    }
}
