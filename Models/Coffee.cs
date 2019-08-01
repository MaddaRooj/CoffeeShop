using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        //[IgnoreDataMember] This tag will make this property hidden in the resulting json data
        [MaxLength(50, ErrorMessage = "Bean type way too long!")]
        public string BeanType { get; set; }
    }
}
