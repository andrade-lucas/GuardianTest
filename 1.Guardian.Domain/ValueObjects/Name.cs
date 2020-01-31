using FluentValidator;
using FluentValidator.Validation;
using Guardian.Domain.Utils;

namespace Guardian.Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new ValidationContract()
                .HasMinLen(FirstName, 2, "FirstName", string.Format(ApplicationMessages.MinStringLength, "Nome", 2))
                .HasMaxLen(FirstName, 60, "FirstName", string.Format(ApplicationMessages.MaxStringLength, "Nome", 60))
            );
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}