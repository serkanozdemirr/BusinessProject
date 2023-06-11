using BusinessProject.BusinessLayer.Abstract;
using BusinessProject.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var values = _employeeService.TGetList();
            return View(values);    
        }
    }
}
