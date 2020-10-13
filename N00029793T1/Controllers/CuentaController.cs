using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N00029793T1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Specialized;

namespace N00029793T1.Controllers
{
    public class CuentaController : Controller
    {
        private N00029793Conex _Context;
        public CuentaController(N00029793Conex context)
        {
            _Context = context;
        }
        [HttpGet]
        public ViewResult index()
        {
            ViewBag.CuentasP = _Context.Cuentas.ToList();
            return View("IndexP");
        }




    }
}
