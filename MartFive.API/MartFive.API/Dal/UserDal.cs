using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class UserDal
    {
        //public bool IsPresent(Models.User user)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    var obj = entities.Users.Where(p => p.User_Email == user.U_email);
        //    if (obj != null && obj.Count() > 0)
        //    {
        //        return true;

        //    }
        //    else
        //        return false;
        //}
        //public bool Add(Models.User user)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    MartfiveDataAccess.User usr = new MartfiveDataAccess.User();
        //    usr.First_Name = user.U_firstName;
        //    usr.Last_Name = user.U_lastName;
        //    usr.User_Email = user.U_email;
        //    usr.User_Phone = user.U_phone;
        //    usr.User_Password = user.U_password;
        //    entities.Users.Add(usr);
        //    entities.SaveChanges();
        //    return true;
        //}

        //public bool Update(Models.User user)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    var usr = entities.Users.Where(p => p.User_Email == user.U_email);
        //    if (usr != null && usr.Count() > 0)
        //    {
        //        usr.First().First_Name = user.U_firstName;
        //        usr.First().Last_Name = user.U_lastName;
        //        usr.First().User_Phone = user.U_phone;
        //        usr.First().User_Password = user.U_password;
        //        entities.SaveChanges();
        //        return true;
        //    }
        //    else
        //        return false;
        //}

        //public Models.User GetUser(Models.User us)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    Models.User user = new Models.User();
        //    var usr = entities.Users.Where(p => p.User_Email == us.U_email);
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


    }
}