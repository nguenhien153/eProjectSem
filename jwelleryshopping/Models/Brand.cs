using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace jwelleryshopping.Models
{
    public class Brandvalidate
    {
        [Key]
        public int BarndID { get; set; }

        [Required(ErrorMessage ="Brand name must not blank")]
        [StringLength(50,MinimumLength =5,ErrorMessage ="Brand name must from 5 to 50 character")]
        public string BarndType { get; set; }
    }

    [MetadataType(typeof(Brandvalidate))]
    public partial class Brand { }
}