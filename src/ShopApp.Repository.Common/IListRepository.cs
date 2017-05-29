using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Domain;

namespace ShopApp.Repository.Common
{
    public interface IListRepository
    {
        bool DoesListExist(string id);
        IEnumerable<ShopList> GetAllAuthorizedLists(string UserId);
        void Insert(ShopList item);
        void Update(ShopList item);
        void Delete(string id);
        
    }
}
