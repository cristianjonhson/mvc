using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc.Models;


namespace mvc.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            return View();
        }

        public string mensaje()
        {
            return "ejemplo de mensaje simple";
        }

        public ActionResult mensaje2()
        {
            return Content("ejemplo content");
        }

        public ActionResult mensaje1()
        {
            return View("vista");
        }

        public ActionResult libro1()
        {
            Libro book = new Libro();
            book.codigo = 10;
            book.nombre = "asp mvc";
            book.precio = 1000;
            ViewData["MiLibro"] = book;
            return View();
        }

        public ActionResult libro2()
        {
            Libro book = new Libro();
            book.codigo = 9;
            book.nombre = "java";
            book.precio = 1500;
            return View(book);
        }

        public ActionResult Agregar()
        {
            return View("View1");
        }
	}
}