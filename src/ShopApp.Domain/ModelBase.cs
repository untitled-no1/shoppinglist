using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Domain
{
    public abstract class ModelBase
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
        public DateTime UpdateDateTime { get; set; }

    }
}
