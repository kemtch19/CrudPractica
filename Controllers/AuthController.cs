using Microsoft.AspNetCore.Mvc;
namespace Mvc.Controllers{
    public class AuthController : Controller{
        public IActionResult Index(){
            return View();
        }
        public IActionResult Login(){
            return View();
        }
        public IActionResult Registro(){
            return View();
        }        
    }
}