using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCorePBI.Controllers
{
    [Route("api/[controller]")]
    public class pedidosController : Controller
    {
        // GET api/pedidos
        [HttpGet]
        public List<Pedidos> Get()
        {
            return Pedidos.LerPedidos();
        }
    }
}
