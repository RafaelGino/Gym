using Application.Base;
using Application.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Abstractions.Notifications;
using Domain.Repositories;
using Infra.Data.Abstractions.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Implementation
{
    public class CustomerService : BaseService, ICustomerService
    {
        private ICustomerRepository customerRepository;
        public CustomerService(INotificationHandler<DomainNotification> domainNotifications, IUnitOfWork unitOfWork, IMediator mediator, IMapper mapper) 
            : base(domainNotifications, unitOfWork, mediator, mapper)
        {
            
        }
        public async Task<CustomerViewModel> GetById(long id)
        {
            var customer = await this.customerRepository.GetByIdAsync(id);
            return this.mapper.Map<CustomerViewModel>(customer);
        }
    }
}
