using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecom.Models
{
    public abstract class BaseEntity
    {
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
    public class RegisterUser : BaseEntity
    {
        [Key]
        public int customer_id { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [MinLength(2, ErrorMessage = "A minimum of 2 is allowed for first name")]
        [MaxLength(30, ErrorMessage = "A maximum of 30 is allowed for first name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Your first name must only contain letters")]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "A minimum of 2 is allowed for last name")]
        [MaxLength(30, ErrorMessage = "A maximum of 30 is allowed for last name")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Your last name must only contain letters")]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(255)]
        public string address { get; set; }
        [Required]
        [MinLength(10)]
        [MaxLength(255)]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(10)]
        public string zip { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(4, ErrorMessage = "A minimum length of 4")]
        [MaxLength(20, ErrorMessage = "A maximum length of 20")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required(ErrorMessage = "Confirm password is required")]
        [DataType(DataType.Password)]
        [Compare("password")]
        [Display(Name = "Confirm Password")]
        public string confirm { get; set; }
    }

    public class LoginUser : BaseEntity
    {
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "This is an email field")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(4, ErrorMessage = "A minimum length of 4")]
        [MaxLength(20, ErrorMessage = "A maximum length of 20")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string password { get; set; }
    }
}