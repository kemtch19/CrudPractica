// retornamos desde el controlador principal
using Microsoft.AspNetCore.Mvc;
//El namespace siempre se debe de llamar así
namespace Mvc.Controllers{
    //heredamos de la clase controller
    public class UserController : Controller{
        //Este método lo que nos devuelve es una vista IActionResult devuelve la vista
        public IActionResult Index(){
            return View();//a menos que sea el index la ruta se coloca dentro de los parentesis
        }
        public IActionResult Mostrar(){
            return View();
        }
        public IActionResult Eliminar(){
            return View();
        }
        public IActionResult Crear(){
            return View();
        }
        public IActionResult Editar(){
            return View();
        }
        public IActionResult Actualizar(){
            return View();
        }
    }
}
