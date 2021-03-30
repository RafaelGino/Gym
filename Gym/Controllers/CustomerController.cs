using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModels;
using Application.ViewModels.Searchs;
using CrossCuting.Http;
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
        public async Task<IActionResult> GetById(long id)
        {
            var result = await this.customerService.GetById(id);
            return base.Result(result);
        }

        [HttpPost("all")]
        public async Task<IActionResult> GetAll([FromBody] RequestSearch<CustomerSearch> request)
        {
            var result = await this.customerService.GetAll(request);
            return base.Result(result);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] CustomerViewModel customerViewModel)
        {
            var idInserido = await this.customerService.Insert(customerViewModel);
            return base.Result(idInserido);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await this.customerService.Delete(id);
            return base.Result();
        }
    }
}
