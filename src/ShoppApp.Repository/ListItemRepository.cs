using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ShopApp.Dal;
using ShopApp.Domain;
using ShopApp.Repository.Common;

namespace ShoppApp.Repository
{
    // TODO Jil Serializer, Id Generators, Other Repos + Controllers



    public class ListItemRepository : IListItemRepository
    {
        private ShopAppDataContext _shopAppDataContext;
        private readonly DbSet<ListItem> _listItems;

        public ListItemRepository(ShopAppDataContext shopAppDataContext)
        {
            _shopAppDataContext = shopAppDataContext;
            _shopAppDataContext.Database.EnsureCreated();

            _listItems = _shopAppDataContext.ListItems;
        }


        public bool DoesListItemExist(string id)
        {
            var item = _listItems.Find("Id", id);
            return item != null;
        }

        public IEnumerable<ListItem> GetAllItemsFromList(string ListId)
        {
            return from i in _listItems
                where i.ParentId == ListId
                select i;

        }

        public void Insert(ListItem item)
        {
            _listItems.Add(item);
            _shopAppDataContext.SaveChanges();
        }

        public void Update(ListItem item)
        {
            _listItems.Update(item);
        }

        public void Delete(string id)
        {
            var itm = _listItems.Find("Id", id);
            _listItems.Remove(itm);
        }
    }
}
