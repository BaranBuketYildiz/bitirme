using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HealthyLife.Models.Sınıflar
{
    public class AdresBlog
    {

        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public string Location { get; set; }

    }
}