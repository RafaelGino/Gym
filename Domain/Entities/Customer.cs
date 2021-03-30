using Domain.Abstractions.Entity;
using Domain.Entities;
using Domain.Enumerators;
using System.Collections.Generic;

namespace Gym.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer(string firstName, string middleName, string lastName, int? age, string address, decimal? weight, decimal? height, string primaryPhone, 
            string secondaryPhone, string email, string zipCode, bool active = true)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Age = age;
            Address = address;
            Weight = weight;
            Height = height;
            PrimaryPhone = primaryPhone;
            SecondaryPhone = secondaryPhone;
            Email = email;
            ZipCode = zipCode;
            Active = active;
        }
        #region Properties        
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public int? Age { get; private set; }
        public string Address { get; private set; }
        public decimal? Weight { get; private set; }
        public decimal? Height { get; private set; }
        public string PrimaryPhone { get; private set; }
        public string SecondaryPhone { get; private set; }
        public string Email { get; private set; }
        public string ZipCode { get; private set; }
        public bool Active { get; private set; } = true;
        public virtual List<Class> Classes { get; private set; }
        //Photo
        #endregion


        public void AddCustomerToClass(IEnumerable<Class> classesToAdd)
        {
            if(this.Classes == null)
                this.Classes = new List<Class>();
            this.Classes.AddRange(classesToAdd);
        }        
    }
}
