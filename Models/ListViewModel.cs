using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlasyamA2.Models
{
    public class ListViewModel
    {
        public ListViewModel(IEnumerable<Event> events, List<Category> categories, string selectedCategory)
        {
            Events = events;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }

        public IEnumerable<Event> Events { get; }
        public List<Category> Categories { get; }
        public string SelectedCategory { get; }
    }
}