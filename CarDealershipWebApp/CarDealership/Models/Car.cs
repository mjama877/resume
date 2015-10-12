using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarDealership.Models
{
    public class Car:IValidatableObject
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors2 = new List<ValidationResult>();

            if (Make == null)
            {
                errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Make" }));
             if (Make == null)
            {
                errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Make" }));
            }
                if (Title == null || Title == "")
                {
                    errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Title" }));
                }
            }
            if (Year == null || (Year.Length != 4))
            {
                errors2.Add(new ValidationResult("Year must be in 'XXXX' format forexample: 1999", new string[] { "Year" }));
            }
            if (Model == null)
            {
                errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Model" }));
            }
            if (Description == null)
            {
                errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Description" }));
            }
            if (Price == null || Price<=0)
            {
                errors2.Add(new ValidationResult("Entry cannot be blank ", new string[] { "Price" }));
  
            }
            if (ImageUrl== null || ImageUrl== "")
            {
                errors2.Add(new ValidationResult("PLEASE ENTER A PICTURE! ", new string[] { "ImageURL" }));

            }
            return errors2;
        }
    }
}