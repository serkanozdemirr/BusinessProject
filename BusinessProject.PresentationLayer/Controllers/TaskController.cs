using BusinessProject.BusinessLayer.Abstract;
using BusinessProject.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.Controllers
{
    public class TaskController : Controller
    {
        private readonly IEmployeeService _employeeService;
        private readonly IOperationService _operationService;

        public TaskController(IEmployeeService employeeService, IOperationService operationService)
        {
            _employeeService = employeeService;
            _operationService = operationService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employeeList = _employeeService.TGetList();
            var operationList = _operationService.TGetList();
            Random random = new Random();
            foreach (Employee employee in employeeList)
            {
                Operation operation = operationList[random.Next(operationList.Count)];
                employee.Operation = operation;
                _employeeService.TUpdate(employee);
                operationList.Remove(operation);
            }
            return View(employeeList);
        }
    }
}
