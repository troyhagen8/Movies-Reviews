using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Review
    {
        public int ID { get; set; }
        public String ReviewerName { get; set; }
        public String comment { get; set; }
    }
}
