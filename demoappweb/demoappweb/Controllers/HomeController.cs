using Microsoft.AspNetCore.Mvc;

namespace demoappweb.Controllers
{
    public class HomeController :Controller
    {
        public ViewResult index()
        {
            return View();
        }
    }
}
