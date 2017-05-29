using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Domain
{
    public class ListItem : ModelBase
    {
        public string Text { get; set; }

        public bool Done { get; set; }

        public string ParentId { get; set; }
    }
}
