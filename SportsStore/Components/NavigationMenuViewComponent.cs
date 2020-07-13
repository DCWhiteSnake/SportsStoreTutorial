using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using SportsStore.Models;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SportsStore.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        private IProductRepository repository;

        public NavigationMenuViewComponent(IProductRepository repo) 
            => repository = repo;
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                        .Select(x => x.Category)
                        .Distinct()
                        .OrderBy(x => x));

        }
       
    }
}
