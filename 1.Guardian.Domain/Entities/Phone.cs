using Guardian.Shared.Entities;

namespace Guardian.Domain.Entities
{
    public class Phone : Entity
    {
        public string Number { get; private set; }

        public Phone(string number)
        {
            Number = number;
        }
    }
}