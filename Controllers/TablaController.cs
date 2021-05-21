using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCrud.Models;
using MVCCrud.Models.ViewModels;

namespace MVCCrud.Controllers
{
    public class TablaController : Controller
    {
        public ActionResult Index()
        {
            List<ListTablaViewModel> lst;
            using (CrudEntities db = new CrudEntities())
            {
                 lst = (from d in db.tabla
                          select new ListTablaViewModel
                          {
                              Id = d.id,
                              Nombre = d.nombre,
                              Correo = d.correo
                          }).ToList();
            }
            return View(lst);
        }
    }
}
 