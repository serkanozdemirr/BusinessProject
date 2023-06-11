using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.ViewComponents.Layout
{
    public class _LayoutFooterPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
