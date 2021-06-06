using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AkulaA2;
using AkulaA2.Models;

namespace AkulaA2.Controllers
{
    public class ArragementsController : Controller
    {
        public IActionResult List(string id = "All")
        {
            
            ArrangementsService arrangementService = new ArrangementsService();
            List<Category> categories = arrangementService.GetCategories();

            List<Arrangement> arrangements = new List<Arrangement>();

      
            if (id == "All")
            {
                arrangements = arrangementService.GetAllArrangements();
            }
            else
            {
                
                int selectedCategoryID = 0;
                foreach (Category cat in categories)
                    if (cat.Name == id)
                        selectedCategoryID = cat.ID;

               
                foreach (Arrangement arrangement in arrangementService.GetAllArrangements())
                {
                    if (arrangement.CategoryID == selectedCategoryID)
                        arrangements.Add(arrangement);
                }
            }

           
            ListViewModel viewModel = new ListViewModel(arrangements, categories, id);

            return View(viewModel);

        }
    }
}