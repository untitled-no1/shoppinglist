using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.Domain;

namespace ShopApp.Repository.Common
{
    public interface IListItemRepository
    {
        bool DoesListItemExist(string id);
        IEnumerable<ListItem> GetAllItemsFromList(string ListId);
        void Insert(ListItem item);
        void Update(ListItem item);
        void Delete(string id);
    }
}
