using Application.ViewModels;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerViewModel> GetById(long id);
    }
}
