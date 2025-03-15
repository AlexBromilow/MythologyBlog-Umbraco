using Microsoft.AspNetCore.Mvc;

namespace MythologyBlog.Web.Components.ViewComponents.DarkModeToggle
{
    public class DarkModeToggleViewComponent : ViewComponent
    {
        private const string ViewName = "~/Components/ViewComponents/DarkModeToggle/DarkModeToggle.cshtml";

        public DarkModeToggleViewComponent() { }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var vm = new DarkModeToggleModel();
            return View(ViewName, vm);
        }
    }
}
