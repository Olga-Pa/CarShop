using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Order
    {

        [BindNever]
        public int id { get; set; }

        [Display(Name = "First Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "minimum 5 signs")]
        public string name { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(25)]
        [Required(ErrorMessage = "minimum 5 signs")]
        public string surname { get; set; }

        [Display(Name = "Address")]
        [StringLength(35)]
        [Required(ErrorMessage = "minimum 5 signs")]
        public string adress { get; set; }

        [Display(Name = "Phone number")]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "minimum 20 digits ")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(25)]
        [Required(ErrorMessage = "minimum 15 signs")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        public List<OrderDetail> orderDetails { get; set; }

    }
}
