using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlasyamA2.Models
{
    public class EventsService
    {
        public List<Event> GetAllEvents()
        {
          
            return allEvents;
        }

        public Event GetEvent(int id)
        {
           
            Event selectedEvent = null;
            foreach (Event anEvent in allEvents)
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

       
        private List<Event> allEvents = new List<Event>
        {
            new Event
            {
                ID= 100,
                Title="Small bouquet",
                CategoryID = 1,
                Price=30,
                Description="Musical based on Disney's animated movie.",
                ImageID= "10.png"
            },
            new Event
            {
                ID= 200,
                Title="Bouquet in vase",
                CategoryID= 2,
                Price=45,
                Description="Holiday extravaganza for the entire family.",
                ImageID= "20.png"
            },
            new Event
            {
                ID= 300,
                Title="Flower plant",
                CategoryID= 1,
                Price=50,
                Description= "The popular musical with seven Tony awards.",
                ImageID= "30.png"
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
