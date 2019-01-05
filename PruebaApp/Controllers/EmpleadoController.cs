using System.Web;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaApp.BLL;
using PruebaApp.Models;

namespace PruebaApp.Controllers
{
    public class EmpleadoController : Controller
    {
     
        // GET: Empleado
        public ActionResult Index()
        {
            return View();
        }

        // GET: Empleado/Details/5
        public JsonResult GetEmpleadoByID(int id)
        {

            
            SalarioBLL salarioBLL = new SalarioBLL();
            Empleado newEmpleado = new Empleado();
            var listEmpleados =  salarioBLL.GetEmpleados();
            if (listEmpleados != null)
            {
                foreach (var item in listEmpleados)
                {
                    if (item.id == id)
                    {
                        SalarioAnualFactory anualFactory = new SalarioAnualFactory();
                        var sal = anualFactory.GetSalarioAnual(item);
                        item.salario = sal.CalculoSalario();
                        newEmpleado = item;
                    }
                }
            }
            
          
            
            return Json(newEmpleado);
        }


        public JsonResult GetEmpleados()
        {


            SalarioBLL salarioBLL = new SalarioBLL();
            var listEmpleados = salarioBLL.GetEmpleados();
            
            List<Empleado> newEmpleadoList = new List<Empleado>();

            foreach (var item in listEmpleados)
            {
                SalarioAnualFactory anualFactory = new SalarioAnualFactory();
                var sal = anualFactory.GetSalarioAnual(item);
                item.salario = sal.CalculoSalario();
                newEmpleadoList.Add(item);
                Debug.WriteLine(item.salario);

            }

            return Json(newEmpleadoList);
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}