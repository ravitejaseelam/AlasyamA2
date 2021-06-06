using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AkulaA2.Models
{
    public class Sale
    {
        public string Code { get; set; }

        [Required(ErrorMessage = "Please enter Customer Name!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please Email Address!")]
        public string Email { get; set; }

        [MaxLength(30)]
        public string Message { get; set; }
      
        public string BDetails { get; set; }
        public string Address { get; set; }
        public bool Delivery { get; set; }
        public double BPrice { get; set; }
     
        [Required(ErrorMessage = "Please select particular Bouquet!")]
        public List<SelectListItem> Options { get; set; }

        public Arrangement SelectedOption { get; set; }
        public string SelectedOptionId { get; set; }
        public string EventName { get; set; }

        public double DCharge { get; set; }

        public double FinalPrice { get; set; }

        public Sale(string eventName, double bouquetprice)
        {
            //Constructor
            EventName = eventName;
            BPrice = bouquetprice;
        }

        public Sale()
        {
            //default contructor            
        }
       
        public string GetBouqte()
        {
            string Bouquet = "";
            if (Code == "SB")
            {
                Bouquet = "Small bouquet";
            }
            else if (Code == "BV")
            {
                Bouquet = "Bouquet in vase";
            }
            else if (Code == "FP")
            {
                Bouquet = "Flower plant";
            }
            return Bouquet;
        }
        public double Price()
        {
            if (Delivery == true)
            {
                DCharge = 5;
            }
            else
            {
                DCharge = 0;
            }

            return DCharge;
        }
        public double GetRate()
        {
            double rate = 0;
            if (Code == "SB")
            {

                rate = 30;
            }
            else if (Code == "BV")
            {
                rate = 45;
            }
            else if (Code == "FP")
            {
                rate = 50;
            }
            return rate;
        }
   

        public double GetTotal()
        {
            FinalPrice = GetRate() + DCharge;
            return FinalPrice;
        }

    }
}