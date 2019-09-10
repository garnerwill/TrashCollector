using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Trash_Collector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "End Date")]

        public DateTime? StartDate { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Pick Up")]
        public bool Pickup { get; set; }
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zipcode")]
        public string Zipcode { get; set; }
        [Display(Name = "Trash Day")]
        public string TrashDay { get; set; }
        public string DaysofWeek { get; set; }
        [Display(Name = "Balance")]
        public Double Balance { get; set; }
        
        [Display(Name = "Extra Pick Up Day")]
        [DataType(DataType.Date)]
        public string ExtraPickUp { get; set; }
        //public Enum DaysOfWeek { get; set; }
        public string pickUpdate { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        [Required]
        [Display(Name = "User Roles")]
        public string UserRoles { get; set; }

        //[Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        //[Required]
        //[Display(Name = "UserName")]
        //public string UserName { get; set; }

        //[Required]
        //[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        //[DataType(DataType.Password)]
        //[Display(Name = "Password")]
        //public string Password { get; set; }

        //[DataType(DataType.Password)]
        //[Display(Name = "Confirm password")]
        //[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        //public string ConfirmPassword { get; set; }
    }
}
