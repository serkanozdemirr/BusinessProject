﻿using Microsoft.AspNetCore.Mvc;

namespace BusinessProject.PresentationLayer.ViewComponents.Layout
{
    public class _LayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
