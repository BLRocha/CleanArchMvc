using CleanArchMvc.Domain.Validation;
using System.Collections.Generic;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : EntityBase
    {
        public string? Name { get; private set; }
    
        public Category(string name)
        {
            ValidationDomain(name);
        }

        public Category(int id, string name)
        {
            ValidationDomain(name);
            DomainExceptionValidation.When(
                id <= 0, "Invalid Id value");
            Id = id;
        }
        public ICollection<Product> Products { get; set; }

        public void Update(string name)
        {
            ValidationDomain(name);
        }
        private void ValidationDomain(string name)
        {
            DomainExceptionValidation.When(
                string.IsNullOrEmpty(name),
                "Invalid name. Name is required"
                );

            DomainExceptionValidation.When(
                name.Length < 3,
                "Invalid name, too short, minimum 3 characters"
                );
            Name = name;
        }
    }
}
