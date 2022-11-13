using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages
{
    public class CustomerCreationEvent: IntegrationEventBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

    }
}
