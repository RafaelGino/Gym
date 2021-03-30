using Domain.Abstractions.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class ClassViewModel: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
