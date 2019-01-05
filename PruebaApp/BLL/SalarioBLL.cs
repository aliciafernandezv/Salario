using Newtonsoft.Json;
using PruebaApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace PruebaApp.BLL
{
    public class SalarioBLL
    {

        public List<Empleado> GetEmpleados()
        {
            var urlCompleta = "http://masglobaltestapi.azurewebsites.net/api/Employees";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlCompleta);
            request.ContentType = "application/json";            

            List<Empleado> resultEmpleado = new List<Empleado>();

            // Respuesta
            try
            {
                HttpWebResponse respuesta = request.GetResponse() as HttpWebResponse;
                //Si la peticion fue correcta
                string resultado = string.Empty;
                if ((int)respuesta.StatusCode == 200)
                {
                    var reader = new StreamReader(respuesta.GetResponseStream());
                    resultado = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject(resultado);

                    Console.WriteLine(resultado);
                    Debug.WriteLine(resultado);
                    resultEmpleado = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Empleado>>(resultado);
                    Debug.WriteLine(resultEmpleado);

                }
                else
                {
                    var reader = new StreamReader(respuesta.GetResponseStream());
                    resultado = reader.ReadToEnd();

                    Console.WriteLine("error");
                    return null;
                    
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);

            }

            return resultEmpleado;

        }
    }
}
