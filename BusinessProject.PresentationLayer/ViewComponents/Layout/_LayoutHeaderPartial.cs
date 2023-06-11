using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.ViewComponents.Layout
{
    public class _LayoutHeaderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
