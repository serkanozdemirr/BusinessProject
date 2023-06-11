using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.ViewComponents.Layout
{
    public class _LayoutScriptPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
