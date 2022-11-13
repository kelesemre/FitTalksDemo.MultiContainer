using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Notification.API.Common
{
    public abstract class EntityBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime? CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public virtual string CreatedByName { get; set; }
        public virtual string ModifiedByName { get; set; }
    }
}
