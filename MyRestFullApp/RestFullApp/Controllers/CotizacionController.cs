using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestFullApp.Controllers
{
    /// <summary>
    /// Se exponen tres metodos para el usuario para
    /// la consulta de la cotización de divisas.. 
    /// </summary>
    public class CotizacionController : ApiController
    {

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string Dolar()
        {
            Contexto_Servicio cs = new Contexto_Servicio();
            cs.SetCotizacion(new CotizaDolar());           
            return cs.Cotizacion().ToString();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string Pesos()
        {
            Contexto_Servicio cs = new Contexto_Servicio();
            cs.SetCotizacion(new CotizaPeso());
            return cs.Cotizacion().ToString();
        }

        [System.Web.Http.AcceptVerbs("GET", "POST")]
        [System.Web.Http.HttpGet]
        public string Reales()
        {
            Contexto_Servicio cs = new Contexto_Servicio();
            cs.SetCotizacion(new CotizaReales());
            return cs.Cotizacion().ToString();
        }
       
    }
}
