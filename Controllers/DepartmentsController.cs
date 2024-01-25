using Course_Aspnetcore_mvc.Models;
using Microsoft.AspNetCore.Mvc;
namespace Course_Aspnetcore_mvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department("Matheus", 20));
            list.Add(new Department("Matheus", 20));
            list.Add(new Department("Matheus", 20));
            list.Add(new Department("Matheus", 20));
            list.Add(new Department("Matheus", 20));
            return View(list);
        }
    }

}