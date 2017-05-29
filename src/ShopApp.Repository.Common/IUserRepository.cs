using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Domain;

namespace ShopApp.Repository.Common
{
    public interface IUserRepository
    {
        bool DoesUserExist(string id);
        bool DoesUserNameExist(string name);
        bool DoesEmailExist(string mail);
        void Insert(User item);
        void Update(User item);
        void Delete(string id);
    }
}
