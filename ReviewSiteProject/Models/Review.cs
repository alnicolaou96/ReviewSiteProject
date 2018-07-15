using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSiteProject.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        [Display(Name ="Product")]
        public string Title { get; set; }
        [Display(Name ="Review")]
        public string Content { get; set; }
        [Display(Name ="Date")]
        public string PublishDate { get; set; }
        //data for the review
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        //retrieves data from the categories 
    }
}