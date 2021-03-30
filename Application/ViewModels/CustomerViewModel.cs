using Domain.Abstractions.Entity;
using Domain.Entities;
using Domain.Enumerators;
using System.Collections.Generic;

namespace Application.ViewModels
{
    public class CustomerViewModel: Entity
    {        
        public string FirstName { get;  set; }
        public string MiddleName { get;  set; }
        public string LastName { get;  set; }
        public int? Age { get;  set; }
        public string Address { get;  set; }
        public decimal? Weight { get;  set; }
        public decimal? Height { get;  set; }
        public string PrimaryPhone { get;  set; }
        public string SecondaryPhone { get;  set; }
        public string Email { get;  set; }
        public string ZipCode { get;  set; }
        public bool Active { get;  set; }
        public IEnumerable<Class> Classes { get; set; }
    }
}
