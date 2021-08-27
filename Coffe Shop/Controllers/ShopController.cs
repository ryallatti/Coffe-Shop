using Coffe_Shop.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffe_Shop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopRepository _shopRepository = null;
        public ShopController()
        {
            _shopRepository = new ShopRepository();
        }
        public IActionResult GetAllItems()
        {
            var data = _shopRepository.GetAllItems();
            return View(data);
        }
        public IActionResult GetItemdetails(int id)
        {
            var data = _shopRepository.GetDetails(id);
            return View(data);
        }
        public IActionResult SearchItem(string name)
        {
            var data = _shopRepository.SearchItems(name);
            return View(data);
        }
        public IActionResult DeleteItem(int id)
        {
            var data = _shopRepository.Delete(id);
            return View(data);
        }
    }
}
