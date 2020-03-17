using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DEMOMVC.Models
{
    public class Validationscls1
    {
        string firstName;
        string lastName;
        double salary;
        string pancard;
        string pwd;
        string confirmpwd;
        string phone;
        string email;
        DateTime doj;
        [Required(ErrorMessage ="Firstname is a must")]
        [StringLength(maximumLength:25,ErrorMessage="Max Length is 25 only")]
        public string FirstName { get => firstName; set => firstName = value; }


        [Required(ErrorMessage = "Lastname is a must")]
        public string LastName { get => lastName; set => lastName = value; }


        [Required(ErrorMessage ="salary is a must")]
        [Range(10000,50000,ErrorMessage="salary should be b/w 10000 and 50000")]
        public double Salary { get => salary; set => salary = value; }

        [Required(ErrorMessage ="Is a must")]
        [RegularExpression("^[A-Z]{5}[0-9]{4}[A-Z]$",ErrorMessage="Invalid Pan")]
        public string Pancard { get => pancard; set => pancard = value; }

        [Required(ErrorMessage ="*")]
        public string Pwd { get => pwd; set => pwd = value; }

        [Required(ErrorMessage ="I a must")]
        [Compare("Pwd",ErrorMessage ="Password Mismatch")]
        [DataType(DataType.Password)]
        public string Confirmpwd { get => confirmpwd; set => confirmpwd = value; }

        [Phone(ErrorMessage ="Not a valid number")]
        [MinLength(10,ErrorMessage ="10 digits only")]
        [MaxLength(10,ErrorMessage ="10 digits only")]
        public string Phone { get => phone; set => phone = value; }
        [EmailAddress(ErrorMessage ="Not a valid Email")]
        public string Email { get => email; set => email = value; }

        
        [Customdoj(ErrorMessage ="Entered date cannot be greator than today's date")]  
        public DateTime Doj { get => doj; set => doj = value; }
    }
}