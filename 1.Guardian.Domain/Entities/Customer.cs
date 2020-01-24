using System;
using System.Collections.Generic;
using Guardian.Domain.ValueObjects;
using Guardian.Shared.Entities;

namespace Guardian.Domain.Entities
{
    public class Customer : Entity
    {
        public Name Name { get; private set; }
        public DateTime Birthdate { get; private set; }
        public Email Email { get; private set; }
        public IEnumerable<string> Phones { get; private set; }
    }
}