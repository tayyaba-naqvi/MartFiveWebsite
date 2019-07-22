using MartFive.API.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MartFive.API.Controllers
{
    public class UserController : ApiController
    {
        //[HttpPost]
        //public bool IsPresent(Models.User user)//   TO CHECK IF EMAIL EXIST AS IT IS UNIQUE AN SIGNUP AND LOGIN IS BASED ON IT. CHECK WHEN SIGNIN UP , put email in user model 
        //{
        //    UserDal userDal = new UserDal();
        //    return userDal.IsPresent(user);
        //}

        //[HttpPost]
        //public Models.User GetLogin(Models.User user)//   TO CHECK IF EMAIL EXIST AS IT IS UNIQUE AN SIGNUP AND LOGIN IS BASED ON IT. CHECK WHEN SIGNIN UP , put email in user model 
        //{
        //    LoginDal loginDal = new LoginDal();
        //    return loginDal.hasAccount(user);
        //}

        //[HttpPost]
        //public bool AddUser(Models.User user)//  ADD NEW USER
        //{
        //    UserDal userDal = new UserDal();
        //    return userDal.Add(user);

        //}

        //[HttpPost]
        //public bool UpdateUser(Models.User user)// EMAIL AND USERID CANNOT BE UPDATED AS THEY BOTH ARE UNIQUE
        //{
        //    UserDal userdal = new UserDal();
        //    return userdal.Update(user);
        //}
    
        //[HttpPost]
        //public Models.User GetUser(Models.User us)
        //{
        //    UserDal userdal = new UserDal();
        //    return userdal.GetUser(us);
        //}

    }
}
