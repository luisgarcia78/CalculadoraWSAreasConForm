using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculadoraWSAreas
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public decimal AreaCuadrado(decimal L1, decimal L2)
        {

            decimal resultado = L1 * L2;
            return resultado;
        }

        [WebMethod]
        public decimal AreaTriangulo(decimal basee, decimal altura)
        {
            decimal resultado = (basee * altura) / 2;
            return resultado;

        }

        [WebMethod]
        public double AreaCirculo(double radio)
        {
            double resultado = 3.1415 * radio * radio;
            return resultado;
        }

    }
}
