using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Treda_Solution_Api.git.Models;

namespace Treda_Solution_Api.git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        public IActionResult Get()
        {
            Tienda oTienda = new Tienda();
            return Ok("okey prr");
        }
    }
}