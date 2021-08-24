using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace alexaWineShop.Models
{
    public class Buy
    {
        public int Id { get; set; }

        [Display(Name = "Brand Name")]
        public string Name { get; set; }

        [Display(Name = "price ")]
        public int Price { get; set; }

        [Display(Name = "Quantity")]
        public int Qty { get; set; }

        [Display(Name = "Party Name")]
        public string PartyName { get; set; }

        [Display(Name = "Date of Billing ")]
        public DateTime Billing { get; set; }


    }
}
