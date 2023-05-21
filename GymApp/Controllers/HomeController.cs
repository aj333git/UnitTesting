using Microsoft.AspNetCore.Mvc;
using GymApp.Models;

namespace GymApp.Controllers {
    public class HomeController : Controller {
   
public ViewResult Index() {
           return View(Product.GetProducts());
        }
    }
}
