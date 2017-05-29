using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Domain
{
    public class User : ModelBase
    {
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
