using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string Brand { get; set; }
        public virtual ICollection<Review> Review { get; set; }
    }
}