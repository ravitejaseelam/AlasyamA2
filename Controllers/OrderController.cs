using AkulaA2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkulaA2.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order(int id)
        {

            ArrangementsService arrangementsService = new ArrangementsService();
            Sale newSale = new Sale();
            newSale.Options = arrangementsService.GetAllArrangements().Select(x=>
            new SelectListItem { Value = x.ID.ToString() , Text = x.Title }).ToList();

            return View(newSale);
        }

        public IActionResult CreateOrder(Sale newSale)
        {
            ArrangementsService arrangementsService = new ArrangementsService();
            newSale.SelectedOption = arrangementsService.GetArrangement(Convert.ToInt32(newSale.SelectedOptionId));
            return View("OrderConfirmation",newSale);
        }
    }
}
