using Integracion.models;
using Microsoft.AspNetCore.Mvc;

namespace Integracion.Controllers
{
    [ApiController]
    [Route("caja")]
    public class TransatController : ControllerBase
    {
        Connect Connect = new Connect();

        [HttpGet]
        [Route("RegistrarCaja")]
        public dynamic listTranst(string nombre, string documento, string tipodocumento, double pago)
        {


            Connect.InsertCajaTrans(nombre, documento, tipodocumento, pago);

            return new
            {

            };
        }

        //[HttpPost]
        //[Route("GruardarCaja")]
        //public IActionResult listTranst(DateTime fecha, string nombre, string documento, string tipodocumento, double pago)
        //{
        //    Connect.InsertCajaTrans(fecha, nombre, documento, tipodocumento, pago);
        //    return Ok("Solicitud lograda");

        //}

    }
}
