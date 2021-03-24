using Domain.Abstractions.Entity;
using Gym.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Class : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }        
        public List<Customer> Customers { get; private set; }
    }
}
