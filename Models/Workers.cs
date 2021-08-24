using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace alexaWineShop.Models
{
    public class Workers
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }


        [Display(Name = "Address ")]
        public string Address { get; set; }


        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Display(Name = "Date of Joining ")]
        public DateTime Joining { get; set; }


    }
}
