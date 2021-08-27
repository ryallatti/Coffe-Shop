using Coffe_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffe_Shop.Repository
{
    public class ShopRepository
    {
       private List<ShopModel> DataSource()
        { 
          List<ShopModel> list = new List<ShopModel>()
           {
               new ShopModel(){Id=1,ItemName="Espresso",Price= 98, Size="small"},
                new ShopModel(){Id=2,ItemName="Latte",Price= 168, Size="medium"},
                 new ShopModel(){Id=3,ItemName="Iced Coffee",Price= 268, Size="large"},
                  new ShopModel(){Id=4,ItemName="Bagels",Price= 88, Size="small"},
                   new ShopModel(){Id=5,ItemName="Donuts",Price= 128, Size="medium"},
                    new ShopModel(){Id=6,ItemName="Croissant",Price= 205, Size="large"}
           };
            return list;
        }
        public List<ShopModel> GetAllItems()
        {
            return DataSource();
        }
        public ShopModel GetDetails(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public int Delete(int id)
        {
            return DataSource().RemoveAll(x => x.Id == id);
        }
        public List<ShopModel> SearchItems(string ItemName)
        {
            return DataSource().Where(x => x.ItemName == ItemName).ToList();
        }
    }
}
