using Customer.API.Entities;
using Customer.API.Repositories;
using EventBus.Messages;
using MassTransit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Customer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        private readonly IPublishEndpoint _publishEndpoint;
        // private readonly ISendEndpointProvider _sendEndpointProvider;

        public CustomerController(IPublishEndpoint publishEndpoint, ICustomerRepository repository)
        {
            _publishEndpoint = publishEndpoint;
            _repository = repository;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<CustomerEntity>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<CustomerEntity>>> GetCustomerList()
        {
            var products = await _repository.GetCustomerList();
            return Ok(products);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CustomerEntity), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<CustomerEntity>> CreateProduct([FromBody] CustomerEntity customerEntity)
        {
            await _repository.CreateCustomer(customerEntity);
            var eventMessage = new CustomerCreationEvent { Email = customerEntity.Email, Name = customerEntity.Name, Surname = customerEntity.Surname };
            //var sendEndPoint = await _sendEndpointProvider.GetSendEndpoint(new Uri("queue:create-order-service")); //MassTransit sending...
            //await sendEndPoint.Send<CreateOrderMessageCommand>(createOrderMessageCommand); //sending a message to RMQ as a command type.
            await _publishEndpoint.Publish<CustomerCreationEvent>(eventMessage); // Publish to MessageBroker

            return Ok(customerEntity);
        }
    }
}
