using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AlasyamA2;
using AlasyamA2.Models;

namespace AlasyamA2.Controllers
{
    public class EventController : Controller
    {
        public IActionResult List(string id = "All")
        {
            
            EventsService eventService = new EventsService();
            List<Category> categories = eventService.GetCategories();

            List<Event> events = new List<Event>();

      
            if (id == "All")
            {
                events = eventService.GetAllEvents();
            }
            else
            {
                
                int selectedCategoryID = 0;
                foreach (Category cat in categories)
                    if (cat.Name == id)
                        selectedCategoryID = cat.ID;

               
                foreach (Event anEvent in eventService.GetAllEvents())
                {
                    if (anEvent.CategoryID == selectedCategoryID)
                        events.Add(anEvent);
                }
            }

           
            ListViewModel viewModel = new ListViewModel(events, categories, id);

            return View(viewModel);

        }

        public IActionResult Details(int id)
        {
           
            EventsService eventService = new EventsService();
            Event oneEvent = eventService.GetEvent(id);

            return View(oneEvent);
        }
    }
}