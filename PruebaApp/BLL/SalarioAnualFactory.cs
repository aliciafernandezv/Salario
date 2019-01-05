using PruebaApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaApp.BLL
{
    public class SalarioAnualFactory
    {
        string contratoHora = "HourlySalaryEmployee";
        string contratoMes = "MonthlySalaryEmployee";

        public Salario GetSalarioAnual(Empleado empleado)
        {
            if(empleado.contractTypeName == contratoHora)
            {
                return new SalarioHora(empleado);
            }

            if (empleado.contractTypeName == contratoMes)
            {
                return new SalarioMensual(empleado);
            }

            return null;
        }
    }
}
