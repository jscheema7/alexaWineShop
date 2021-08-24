using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace alexaWineShop.Models
{
    public class Attendence
    {

        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Contact ")]
        public string Contact { get; set; }


      
        [Display(Name = "Designation")]
        public string Designation { get; set; }

        [Display(Name = "Date of Attendence")]
        public DateTime WAttendence { get; set; }

        public Workers workers { get; set; }  
    }
}
