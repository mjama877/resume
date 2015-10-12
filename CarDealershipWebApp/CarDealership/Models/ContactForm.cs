using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarDealership.Models
{
    public class ContactForm : IValidatableObject
    {
        // Your task is to:
        //
        // Make all fields required
        // Ensure the Email field contains an '@' symbol
        // Ensure PhoneNumber is in the format: 1-XXX-XXX-XXXX
        // If the Income is less than 10000 and the PurchaseTimeFrameInMonts is greater than 12,
        // generate a model level area that says 'We don't want your business!'

        public string Name { get; set; }
        public int PurchaseTimeFrameInMonths { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal? Income { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (Name == null)
            {
                errors.Add(new ValidationResult("Name cannot be blank ", new string[] { "Name" }));
            }
            if (PhoneNumber== null || (PhoneNumber.Length!=12) || PhoneNumber[3]!='-' || PhoneNumber[7]!='-' )
            {
                errors.Add(new ValidationResult("Phone # must not be blank, please enter in this format XXX-XXX-XXXX", new string[] { "PhoneNumber" }));
            }
            if (Email == null || !Email.Contains("@"))
            {
                errors.Add(new ValidationResult("Email cannot be blank, must include @ symbol", new string[] { "Email" }));
            }
            if (Income == null || Income < 20000)
            {
                errors.Add(new ValidationResult("Income must not be blank, must be greater than $20,000", new string[] { "Income" }));
            }
            if ( PurchaseTimeFrameInMonths > 12)
            {
                errors.Add(new ValidationResult("WE DON'T WANT YOUR BUSINESS", new string[] { "PurchaseTimeFrameInMonths" }));
            }
            return errors;
        }
    }
}