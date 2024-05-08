using Microsoft.AspNetCore.Mvc;
using ASP_LR9.Models;

namespace ASP_LR9.Components
{
    public class ProductsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(List<Product> products)
        {
            return View(products);
        }
    }
}