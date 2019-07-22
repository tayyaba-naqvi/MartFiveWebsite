using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class CategoryDal
    {
        //public bool addCategory(Models.Category category)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    MartfiveDataAccess.Category cat = new MartfiveDataAccess.Category();
        //    if (category != null)
        //    {
        //        cat.Category_Name = category.category_Name;
        //        cat.Pic_Id = category.pic_Id;
        //        entities.Categories.Add(cat);
        //        entities.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //public bool updateCategory(Models.Category category)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    string test = string.Empty;
        //    var cat = entities.Categories.Where(p => p.Category_Id == category.category_Id);
        //    if (cat != null && cat.Count() > 0)
        //    {
        //        if (!(category.category_Name.Equals(test)))
        //        {
        //            cat.FirstOrDefault().Category_Name = category.category_Name;
        //        }
        //        cat.FirstOrDefault().Pic_Id = category.pic_Id;
        //        entities.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //public List<Models.Category> ShowAllCategories()

        //{

        //    PagalMartEntities entities = new PagalMartEntities();

        //    List<Models.Category> list = new List<Models.Category>();

        //    var obj = entities.Categories.Select(p => p);

        //    if (obj != null && obj.Count() > 0)

        //    {

        //        foreach (var objj in obj)

        //        {

        //            Models.Category cat = new Models.Category();

        //            cat.category_Id = objj.Category_Id;

        //            cat.category_Name = objj.Category_Name;

        //            cat.pic_Id = objj.Pic_Id;

        //            list.Add(cat);

        //        }

        //    }

        //    return list;

        //}


        //public Models.Category ShowByID(Models.Category cat)

        //{

        //    PagalMartEntities entities = new PagalMartEntities();

        //    var obj = entities.Categories.Where(p => p.Category_Id == cat.category_Id);

        //    if (obj != null && obj.Count() > 0)

        //    {

        //        cat.category_Id = obj.First().Category_Id;

        //        cat.category_Name = obj.First().Category_Name;

        //        cat.pic_Id = obj.First().Pic_Id;


        //    }

        //    return cat;

        //}
    }
}