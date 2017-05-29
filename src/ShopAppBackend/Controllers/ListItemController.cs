using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using ShopApp.Dal;
using ShopApp.Domain;
using ShopApp.Repository.Common;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ShopAppBackend.Controllers
{
    [Route("api/[controller]")]
    public class ListItemController : Controller
    {
        private IListItemRepository _listItemRepository;

        public ListItemController(IListItemRepository listItemRepository)
        {
            _listItemRepository = listItemRepository;
        }


        [HttpGet]
        public IActionResult ApiTest()
        {
            return Ok("Initialized");
        }

        [HttpGet]
        [Route("{ShoppingListId}")]
        public IActionResult List(string ShoppingListId)
        {
            var items = _listItemRepository.GetAllItemsFromList(ShoppingListId);
            return Ok(items);
        }

        [HttpPost]
        public IActionResult InsertItem([FromBody]ListItem itm)
        {
            _listItemRepository.Insert(itm);
            return Ok(itm);
        }
    }
}
