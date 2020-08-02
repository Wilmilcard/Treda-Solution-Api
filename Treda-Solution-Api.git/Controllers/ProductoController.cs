﻿using System;
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
    public class ProductoController : ControllerBase
    {
        [HttpPost()]
        public IActionResult AgregarTienda(Models.Request.ProductoRequest model)
        {
            try
            {
                using (ApplicationDbContext db = new ApplicationDbContext())
                {
                    var oProducto = new Producto();
                    oProducto.Nombre = model.Nombre;
                    oProducto.SKU = model.SKU;
                    oProducto.Descripcion = model.Descripcion;
                    oProducto.Valor = model.Valor;
                    oProducto.Tienda = model.Tienda;
                    oProducto.Imagen = model.Imagen;
                    db.Producto.Add(oProducto);
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