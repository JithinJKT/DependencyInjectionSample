using DependencyInjectionSample.Models;
using DependencyInjectionSample.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DependencyInjectionSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScopedService _scoped1;
        private readonly IScopedService _scoped2;
        private readonly ISingletonService _singleton1;
        private readonly ISingletonService _singleton2;
        private readonly ITransientService _transien1;
        private readonly ITransientService _transien2;

        public HomeController(IScopedService scopedService1, IScopedService scopedService2,
            ISingletonService singletonService1, ISingletonService singletonService2,
            ITransientService transientService1, ITransientService transientService2)
        {
            _scoped1=scopedService1;
            _scoped2=scopedService2;
            _singleton1=singletonService1;
            _singleton2=singletonService2;
            _transien1=transientService1;
            _transien2=transientService2;
        }

        public IActionResult Index()
        {
            StringBuilder message = new StringBuilder();
            message.Append($"Transient 1 : {_transien1.GetGuid()}\n");
            message.Append($"Transient 2 : {_transien2.GetGuid()}\n\n\n");
            message.Append($"Scoped 1 : {_scoped1.GetGuid()}\n");
            message.Append($"Scoped 2 : {_scoped2.GetGuid()}\n\n\n");
            message.Append($"Singleton 1 : {_singleton1.GetGuid()}\n");
            message.Append($"Singleton 2 : {_singleton2.GetGuid()}\n");
            return Ok(message.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
