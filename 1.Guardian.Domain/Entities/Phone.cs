using System.Text.RegularExpressions;
using FluentValidator.Validation;
using Guardian.Domain.Utils;
using Guardian.Shared.Entities;

namespace Guardian.Domain.Entities
{
    public class Phone : Entity
    {
        public string Number { get; private set; }

        public Phone(string number)
        {
            Number = number.Replace("(", "").Replace(")", "").Replace(" ", "");
            AddNotifications(new ValidationContract()
                .Requires()
                .IsTrue(this.Validate(), "Phone", ApplicationMessages.InvalidPhone)
            );
        }

        private bool Validate()
        {
            Regex validator = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
            return validator.IsMatch(Number);
        }
    }
}