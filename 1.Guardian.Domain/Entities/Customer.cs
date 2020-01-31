using System;
using System.Collections.Generic;
using Guardian.Domain.ValueObjects;
using Guardian.Shared.Entities;

namespace Guardian.Domain.Entities
{
    public class Customer : Entity
    {
        private readonly IList<Phone> _phones;

        public Name Name { get; private set; }
        public DateTime Birthdate { get; private set; }
        public Email Email { get; private set; }
        public IEnumerable<Phone> Phones => this._phones;

        public Customer(Name name, DateTime birthdate, Email email)
        {
            Name = name;
            Birthdate = birthdate;
            Email = email;
            _phones = new List<Phone>();
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}