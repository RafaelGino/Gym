using Application.ViewModels;
using Application.ViewModels.Searchs;
using CrossCuting.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClassService
    {
        Task<ClassViewModel> GetById(long id);
        Task<ResponseList<ClassViewModel>> GetAll(RequestSearch<ClassSearch> request);
        Task<long> Insert(ClassViewModel customerViewModel);
        Task Delete(long id);
    }
}
