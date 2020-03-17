using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DEMOMVC.Models
{
    public class Customdoj:ValidationAttribute
    {
        //    public override bool IsValid(object value)
        //    {
        //        DateTime D = Convert.ToDateTime(value);
        //        return D <= DateTime.Now;//the date entered for doj should be last than or equal to today's date
        //    }
        //}
        //public class customAge:ValidationAttribute
        //{
        //    public override bool IsValid(object value)
        //    {
        //        DateTime D = Convert.ToDateTime(value);
        //        DateTime TD = DateTime.Today;
        //        int age = (int)(TD.Subtract(D).TotalDays / 365);
        //        if (age >= 21 && age <= 58)
        //            return true;
        //        else
        //            return false;

        //    }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime D = Convert.ToDateTime(value);
            DateTime TD = DateTime.Today;
            int age = (int)(TD.Subtract(D).TotalDays / 365);
            if (D > TD)
                return new ValidationResult("date cannot be greator than today's date");
            else if (age < 21 || age > 58)
                return new ValidationResult("age must be b/w 21 and 58");
            else
                return ValidationResult.Success;
        }
    }

}