using BusinessProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.Controllers
{
    public class OperationController : Controller
    {
        private readonly IOperationService _operationService;

        public OperationController(IOperationService operationService)
        {
            _operationService = operationService;
        }
        public IActionResult Index()
        {
            var values = _operationService.TGetList();
            return View(values);
        }
    }
}
