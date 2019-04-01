using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TParendre.Models;


namespace TParendre.Controllers
{
    public class BibliothequesController : Controller
    {
        // GET: Bibliotheques
        public ActionResult Index()
        {
            var bibliotheque = new Bibliotheque() { Name = "Heritage" };

            return View(bibliotheque);
        }
    }
}