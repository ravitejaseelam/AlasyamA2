using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkulaA2.Models
{
    public class ListViewModel
    {
        public ListViewModel(IEnumerable<Arrangement> arrangements, List<Category> categories, string selectedCategory)
        {
            Arrangements = arrangements;
            Categories = categories;
            SelectedCategory = selectedCategory;
        }

        public IEnumerable<Arrangement> Arrangements { get; }
        public List<Category> Categories { get; }
        public string SelectedCategory { get; }
    }
}