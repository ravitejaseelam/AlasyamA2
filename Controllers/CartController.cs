using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using AlasyamA2;
using AlasyamA2.Models;

namespace AlasyamA2.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Buy(int id)
        {
            
            EventsService eventService = new EventsService();
            Event selectedEvent = eventService.GetEvent(id);
            Sale newSale = new Sale(selectedEvent.Title, selectedEvent.Price);

            return View(newSale);
        }

        public IActionResult Confirmation(Sale model)
        {
 
            if (ModelState.IsValid)
            {
                

                return View(model);
            }
            else
            {
                return View("Buy", model);
            }
        }

    }
}