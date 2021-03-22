using Domain.Abstractions.Entity;

namespace Gym.Domain.Entities
{
    public class Customer : Entity
    {
        #region Properties
        public string Name { get; private set; }
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public string Address { get; private set; }
        public decimal Weight { get; private set; }
        public decimal Height { get; private set; }
        public string PrimaryPhone { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string ZipCode { get; private set; }
        //Photo
        #endregion
        
    }
}
