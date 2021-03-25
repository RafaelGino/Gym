using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModels;
using Domain.Abstractions.Notifications;
using Gym.Base;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController
    {
        private readonly ICustomerService customerService;
        public CustomerController(INotificationHandler<DomainNotification> domainNotification, ICustomerService customerService) : base(domainNotification)
        {
            this.customerService = customerService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomerById(long id)
        {
            var result = await this.customerService.GetById(id);
            return base.Result(result);
        }
    }
}
