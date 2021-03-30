using Application.Base;
using Application.Interfaces;
using Application.ViewModels;
using Application.ViewModels.Searchs;
using AutoMapper;
using CrossCuting.Http;
using Domain.Abstractions.Notifications;
using Domain.Repositories;
using Gym.Domain.Entities;
using Infra.Data.Abstractions.Data;
using Infra.Data.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class CustomerService : BaseService, ICustomerService
    {
        private ICustomerRepository customerRepository;
        public CustomerService(INotificationHandler<DomainNotification> domainNotifications, IUnitOfWork unitOfWork, IMediator mediator, IMapper mapper, ICustomerRepository customerRepository) 
            : base(domainNotifications, unitOfWork, mediator, mapper)
        {
            this.customerRepository = customerRepository;
        }

        public async Task<CustomerViewModel> GetById(long id)
        {
            var customer = await this.customerRepository.GetByIdAsync(id);
            return this.mapper.Map<CustomerViewModel>(customer);
        }

        public async Task<ResponseList<CustomerViewModel>> GetAll(RequestSearch<CustomerSearch> request)
        {
            var result = await this.customerRepository.GetAllAsync(request.Page, request.PageSize, request.Search.GetFilter(), request.Search.GetOrderBy(), request.Search.GetIncludes());
            return base.CreateResultListModel<Customer, CustomerViewModel>(result);
        }

        public async Task<long> Insert(CustomerViewModel customerViewModel)
        {
            var customer = new Customer(customerViewModel.FirstName, customerViewModel.MiddleName, customerViewModel.LastName, customerViewModel.Age,
                customerViewModel.Address, customerViewModel.Weight, customerViewModel.Height, customerViewModel.PrimaryPhone, customerViewModel.SecondaryPhone,
                customerViewModel.Email, customerViewModel.ZipCode);

            customer.AddCustomerToClass(customerViewModel.Classes);
            await this.customerRepository.InsertAsync(customer);
            await this.CommitAsync();
            return customer.Id;
        }

        public async Task Delete(long id)
        {
            await this.customerRepository.DeleteAsync(id);
            await this.CommitAsync();
        }
    }
}
