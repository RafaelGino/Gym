using Domain.Abstractions.Entity;
using Domain.Entities;
using Domain.Enumerators;
using System.Collections.Generic;

namespace Gym.Domain.Entities
{
    public class Customer : Entity
    {
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
        public bool Active { get; private set; }
        public virtual IList<Class> Classes { get; private set; }
        //Photo
        #endregion
        
    }
}
