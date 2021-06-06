using AkulaA2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkulaA2.Models
{
    public class ArrangementsService
    {
        public List<Arrangement> GetAllArrangements()
        {
          
            return allArrangements;
        }

        public Arrangement GetArrangement(int id)
        {
           
            Arrangement selectedEvent = null;
            foreach (Arrangement anEvent in allArrangements)
            {
                if (anEvent.ID == id)
                    selectedEvent = anEvent;
            }
            return selectedEvent;
        }


        public List<Category> GetCategories()
        {
     
            return categories;
        }

       
        private List<Arrangement> allArrangements = new List<Arrangement>
        {
            new Arrangement
            {
                ID= 100,
                Title="Small bouquet",
                CategoryID = 1,
                Price=30,
                Description="For your loved ones",
                ImageSrc= "../Images/bouqet.png"
            },
            new Arrangement
            {
                ID= 200,
                Title="Bouquet in vase",
                CategoryID= 2,
                Price=45,
                Description="For your family occassion.",
                ImageSrc= "../Images/vase.png"
            },
            new Arrangement
            {
                ID= 300,
                Title="Flower plant",
                CategoryID= 1,
                Price=50,
                Description= "For your garden",
                ImageSrc= "../Images/plant.png"
            },

        };

        private List<Category> categories = new List<Category>
        {
            new Category
            {
                ID =1,
                Name="Simple Flowers"
            },
            new Category
            {
                ID =2,
                Name="Flower Pot"
            },
        };

    }
}
