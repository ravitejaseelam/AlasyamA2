using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlasyamA2.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CategoryID { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageID { get; set; }
    }
}
