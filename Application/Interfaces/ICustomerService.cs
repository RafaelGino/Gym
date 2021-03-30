using Application.ViewModels;
using Application.ViewModels.Searchs;
using CrossCuting.Http;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICustomerService
    {
        Task<CustomerViewModel> GetById(long id);
        Task<ResponseList<CustomerViewModel>> GetAll(RequestSearch<CustomerSearch> request);
        Task<long> Insert(CustomerViewModel customerViewModel);
        Task Delete(long id);
    }
}
