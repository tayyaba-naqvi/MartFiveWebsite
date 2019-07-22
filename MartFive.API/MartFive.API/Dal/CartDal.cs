using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class CartDal
    {
        /*
        public bool AddToCart(Models.Cart cart)
        {
            PagalMartEntities entities = new PagalMartEntities();
            MartfiveDataAccess.Cart crt = new MartfiveDataAccess.Cart();
            crt.Cart_Id = cart.C_Id;
            crt.Cart_Quantity = cart.C_Quantity.ToString();
            crt.Item_Id = cart.C_ItemId;
            crt.User_Id = cart.C_UserID;
            entities.Carts.Add(crt);
            entities.SaveChanges();
            return true;
        }

        public List<Models.Cart> ShowCart(Models.User usr)
        {
            PagalMartEntities entities = new PagalMartEntities();
            List<Models.Cart> list = new List<Models.Cart>();
            var obj = entities.Carts.Where(p => p.User_Id == usr.U_ID);
            if (obj != null && obj.Count() > 0)
            {
                foreach (var objj in obj)
                {
                    Models.Cart m_cart = new Models.Cart();
                    m_cart.C_Id = objj.Cart_Id;
                    m_cart.C_ItemId = objj.Item_Id;
                    m_cart.C_Quantity = Int32.Parse(objj.Cart_Quantity);
                    m_cart.C_UserID = objj.User_Id;
                    list.Add(m_cart);
                }
            }
            return list;
        }

        public bool IncreaseQuantity(Models.Cart cart)
        {
            PagalMartEntities entities = new PagalMartEntities();
            var obj = entities.Carts.Where(p => p.User_Id == cart.C_UserID && p.Item_Id == cart.C_ItemId);
            if (obj != null && obj.Count() > 0)
            {
                int quan = Int32.Parse(obj.First().Cart_Quantity);
                quan++;
                obj.First().Cart_Quantity = quan.ToString();
                entities.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool DecreaseQuantity(Models.Cart cart)
        {
            PagalMartEntities entities = new PagalMartEntities();
            var obj = entities.Carts.Where(p => p.User_Id == cart.C_UserID && p.Item_Id == cart.C_ItemId);
            if (obj != null && obj.Count() > 0)
            {
                int quan = Int32.Parse(obj.First().Cart_Quantity);
                quan = quan - 1;
                obj.First().Cart_Quantity = quan.ToString();
                entities.SaveChanges();
                if (quan == 0)
                {
                    var itemToRemove = entities.Carts.SingleOrDefault(p => p.User_Id == cart.C_UserID && p.Item_Id == cart.C_ItemId);
                    if (itemToRemove != null)
                    {
                        entities.Carts.Remove(itemToRemove);
                        entities.SaveChanges();
                    }
                }
                return true;

            }
            return false;
        }

        public bool DeleteItem(Models.Cart cart)
        {
            PagalMartEntities entities = new PagalMartEntities();
            var itemToRemove = entities.Carts.SingleOrDefault(p => p.User_Id == cart.C_UserID && p.Item_Id == cart.C_ItemId);
            if (itemToRemove != null)
            {
                entities.Carts.Remove(itemToRemove);
                entities.SaveChanges();
                return true;
            }
            return true;

        }*/
    }
}