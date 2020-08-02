using System;
using System.Collections.Generic;
using System.IO;
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
        ApplicationDbContext db;
        public IActionResult Get()
        {
            IList<Tienda> tienda = null;

            try
            {
                using (db = new ApplicationDbContext())
                {
                    tienda = db.Tienda.ToList<Tienda>();
                }

                if (tienda.Count == 0)
                {
                    return NotFound();
                }


                return Ok(tienda);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        [HttpPost()]
        public IActionResult AgregarTienda(Models.Request.TiendaRequest model)
        {
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var oTienda = new Tienda();
                    oTienda.Id = model.Id;
                    oTienda.Nombre = model.Nombre;
                    oTienda.FechaApertura = model.FechaApertura;
                    db.Tienda.Add(oTienda);
                    db.SaveChanges();
                }

                return Ok("Cargado");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
            
        }
    }
}