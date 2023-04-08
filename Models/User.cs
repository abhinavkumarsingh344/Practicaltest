using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
namespace PracticalTest.Models
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the name ")]
       
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter Your Email ")]
       // [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "Email not correct")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number ")]
        //[RegularExpression("\\+?\\d[\\d -]{8,12}\\d", ErrorMessage = "PhoneNumber not correct")]
        public int PhoneNo { get; set; }
        public string Address { get;set; }
        public string State { get; set; }
        public string City { get; set; }
        //public string Agree { get; set; }

    }
}
