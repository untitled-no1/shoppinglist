using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.Domain
{
    public class ShopList : ModelBase
    {
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        private IList<string> _authorizedUsers = new List<string>();

        public bool IsUserAuthorized(string id)
        {
            return _authorizedUsers.Contains(id);
        }

        public void AddUser(string id)
        {
            _authorizedUsers.Add(id);
        }

    }
}
