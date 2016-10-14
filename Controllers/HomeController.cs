using EFCOREDEMO;
using EFCOREDEMO.Models;
using Microsoft.AspNetCore.Mvc;

namespace EfCoreDemo.Controllers
{

    public class HomeController : Controller
    {
        private AppDBContext db = new AppDBContext();
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Alumno(){

            ViewData["Message"]="Mensaje desde vista de Alumno";
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult GuardarAlumno(Alumno Alumno){
            db.Alumnos.Add(Alumno);
            db.SaveChanges();
            return RedirectToAction("Alumno");

        }
    }
}
