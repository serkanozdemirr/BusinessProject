using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.ViewComponents.Layout
{
    public class _LayoutSidebarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
