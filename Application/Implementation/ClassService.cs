using Application.Base;
using Application.Interfaces;
using Application.ViewModels;
using Application.ViewModels.Searchs;
using AutoMapper;
using CrossCuting.Http;
using Domain.Abstractions.Notifications;
using Domain.Entities;
using Domain.Repositories;
using Infra.Data.Abstractions.Data;
using MediatR;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class ClassService : BaseService, IClassService
    {
        private IClassRepository classRepository;
        public ClassService(INotificationHandler<DomainNotification> domainNotifications, IUnitOfWork unitOfWork, IMediator mediator, IMapper mapper, IClassRepository classRepository)
            : base(domainNotifications, unitOfWork, mediator, mapper)
        {
            this.classRepository = classRepository;
        }

        public async Task<ClassViewModel> GetById(long id)
        {
            var customer = await this.classRepository.GetByIdAsync(id);
            return this.mapper.Map<ClassViewModel>(customer);
        }

        public async Task<ResponseList<ClassViewModel>> GetAll(RequestSearch<ClassSearch> request)
        {
            var result = await this.classRepository.GetAllAsync(request.Page, request.PageSize, request.Search.GetFilter(), request.Search.GetOrderBy(), null);
            return base.CreateResultListModel<Class, ClassViewModel>(result);
        }

        public async Task<long> Insert(ClassViewModel customerViewModel)
        {
            var newClass = new Class(customerViewModel.Name, customerViewModel.Description);
            await this.classRepository.InsertAsync(newClass);
            await this.CommitAsync();
            return newClass.Id;
        }

        public async Task Delete(long id)
        {
            await this.classRepository.DeleteAsync(id);
            await this.CommitAsync();
        }
    }
}
