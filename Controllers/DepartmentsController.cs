using Microsoft.AspNetCore.Mvc;
using workshop_asp_net_core_mvc.Models;

namespace workshop_asp_net_core_mvc.Controllers;

public class DepartmentsController : Controller
{
    
    public IActionResult Index()
    {
        List<Department> departments = new List<Department>();
        departments.Add(new Department(1, "Eletronics", true));
        departments.Add(new Department(2, "Fashion", true));
        departments.Add(new Department(3, "Footwear", false));
        departments.Add(new Department(4, "Hear", true));
        
        return View(departments);
    }
}