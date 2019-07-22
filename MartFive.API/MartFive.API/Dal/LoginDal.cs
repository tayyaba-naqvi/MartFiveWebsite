using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class LoginDal
    {
            //public Models.User hasAccount(Models.User us) 
            //{

            //    PagalMartEntities entities = new PagalMartEntities();
            //    Models.User user = new Models.User();
            //    var usr = entities.Users.Where(p => p.User_Email == us.U_email && p.User_Password == us.U_password);
            //    if (usr != null && usr.Count() > 0)
            //    {
            //        user.U_ID = usr.First().User_Id;
            //        user.U_firstName = usr.First().First_Name;
            //        user.U_lastName = usr.First().Last_Name;
            //        user.U_password = usr.First().User_Password;
            //        user.U_phone = usr.First().User_Phone;
            //        user.U_email = usr.First().User_Email;

            //    }
            //    return user;

            //}

            //public bool isCorrectPassword(Models.User user)
            //{
            //    PagalMartEntities entities = new PagalMartEntities();
            //    var obj = entities.Users.Where(p => p.User_Email == user.U_email);
            //    if (obj != null && obj.Count()>0 )
            //    {
            //        string s = obj.First().User_Password;
            //        if (s.Equals( user.U_password))
            //        {
            //            return true;

            //        }
            //        else
            //            return false;
            //    }
            //    else
            //        return false;

            //}

            //public bool setPassword(Models.User user) 
            //{
            //    PagalMartEntities entities = new PagalMartEntities();
            //    var obj = entities.Users.Where(p => p.User_Email == user.U_email);
            //    if (obj != null && obj.Count()>0)
            //    {
            //        obj.First().User_Password = user.U_password;
            //        entities.SaveChanges();
            //        return true;
            //    }
            //    else
            //        return false;
            //}

        
    }
}