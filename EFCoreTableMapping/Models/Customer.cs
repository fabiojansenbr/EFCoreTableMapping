using System;

namespace EFCoreTableMapping.Models
{
    public class Customer
    {

        public Customer(string name, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
        }

        protected Customer()
        {
        }

        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public bool IsValid()
        {
            return Name.Length > 3 && Name.Length <= 150;
        }
    }
}
