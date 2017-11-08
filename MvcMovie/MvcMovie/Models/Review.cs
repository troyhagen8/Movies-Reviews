using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    { 

        public int ID { get; set; }
    
        public int MovieID { get; set; }

        [Display(Name="Your name")]
        public String ReviewerName { get; set; }

        public String Comment { get; set; }
    }
}
