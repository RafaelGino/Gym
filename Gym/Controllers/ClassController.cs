using Application.Interfaces;
using Application.ViewModels;
using Application.ViewModels.Searchs;
using CrossCuting.Http;
using Domain.Abstractions.Notifications;
using Gym.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : BaseController
    {
        private readonly IClassService classService;
        public ClassController(INotificationHandler<DomainNotification> domainNotification, IClassService classService) : base(domainNotification)
        {
            this.classService = classService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var result = await this.classService.GetById(id);
            return base.Result(result);
        }

        [HttpPost("all")]
        public async Task<IActionResult> GetAll([FromBody] RequestSearch<ClassSearch> request)
        {
            var result = await this.classService.GetAll(request);
            return base.Result(result);
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] ClassViewModel customerViewModel)
        {
            var idInserido = await this.classService.Insert(customerViewModel);
            return base.Result(idInserido);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await this.classService.Delete(id);
            return base.Result();
        }
    }
}
