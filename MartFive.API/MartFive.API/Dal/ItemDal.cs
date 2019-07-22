using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class ItemDal
    {
       /* public bool addItem(Models.Item item)
        {
            PagalMartEntities entities = new PagalMartEntities();
            MartfiveDataAccess.Item itm = new MartfiveDataAccess.Item();
            if (item != null)
            {
                itm.Item_Name = item.item_Name;
                itm.Item_Price = item.item_Price;
                itm.Item_Description = item.item_Description;
                itm.Item_Quantity = item.item_Quantity;
                itm.Pic_Id = item.pic_Id;
                itm.SCat_Id = item.sCat_Id;
                entities.Items.Add(itm);
                entities.SaveChanges();
                return true;
            }
            return false;
        }
        public bool updateItem(Models.Item item)
        {
            PagalMartEntities entities = new PagalMartEntities();
            var itm = entities.Items.Where(p => p.Item_Id == item.item_Id);
            if (itm != null && itm.Count() > 0)
            {
                itm.FirstOrDefault().Item_Name = item.item_Name;
                itm.FirstOrDefault().Item_Price = item.item_Price;
                itm.FirstOrDefault().Item_Description = item.item_Description;
                itm.FirstOrDefault().Item_Quantity = item.item_Quantity;
                itm.FirstOrDefault().Pic_Id = item.pic_Id;
                itm.FirstOrDefault().SCat_Id = item.sCat_Id;
                entities.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Models.Item> ShowAllItems()
        {
            PagalMartEntities entities = new PagalMartEntities();
            List<Models.Item> list = new List<Models.Item>();
            var obj = entities.Items.Select(p => p);
            if (obj != null && obj.Count() > 0)
            {
                foreach (var objj in obj)
                {
                    Models.Item itm = new Models.Item();
                    itm.item_Id = objj.Item_Id;
                    itm.item_Name = objj.Item_Name;
                    itm.item_Price = (int)objj.Item_Price;
                    itm.item_Description = objj.Item_Description;
                    itm.item_Quantity = (int)objj.Item_Quantity;
                    itm.pic_Id = objj.Pic_Id;
                    itm.sCat_Id = objj.SCat_Id;
                    list.Add(itm);
                }
            }
            return list;
        }

        public Models.Item ShowByID(Models.Item itm)
        {
            PagalMartEntities entities = new PagalMartEntities();
            var objj = entities.Items.Where(p => p.Item_Id == itm.item_Id);
            if (objj != null && objj.Count() > 0)
            {
                itm.item_Id = objj.First().Item_Id;
                itm.item_Name = objj.First().Item_Name;
                itm.item_Price = (int)objj.First().Item_Price;
                itm.item_Description = objj.First().Item_Description;
                itm.item_Quantity = (int)objj.First().Item_Quantity;
                itm.pic_Id = objj.First().Pic_Id;
                itm.sCat_Id = objj.First().SCat_Id;
            }
            return itm;
        }*/

    }
}