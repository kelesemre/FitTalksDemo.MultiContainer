using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Messages
{
    public class IntegrationEventBase
    {
        public IntegrationEventBase()
        {
            Id = Guid.NewGuid(); // Since private set.
            CreationDate = DateTime.UtcNow;
        }

        public IntegrationEventBase(Guid id, DateTime createDate)
        {
            Id = id;
            CreationDate = createDate;
        }

        public Guid Id { get; private set; } // CorrelationId , it's used for tracking 

        public DateTime CreationDate { get; private set; }
    }
}
