using MartfiveDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartFive.API.Dal
{
    public class SubCategoryDal
    {
        //public bool addSubCategory(Models.SubCategory category)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    MartfiveDataAccess.SubCategory cat = new MartfiveDataAccess.SubCategory();
        //    if (category != null)
        //    {
        //        cat.SCat_Name = category.sCat_Name;
        //        cat.Category_Id = category.category_Id;
        //        entities.SubCategories.Add(cat);
        //        entities.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}

        //public bool updateSubCategory(Models.SubCategory category)
        //{
        //    PagalMartEntities entities = new PagalMartEntities();
        //    string test = string.Empty;
        //    var cat = entities.SubCategories.Where(p => p.SCat_Id == category.sCat_Id);
        //    if (cat != null && cat.Count() > 0)
        //    {
        //        if (!(category.sCat_Name.Equals(test)))
        //        {
        //            cat.FirstOrDefault().SCat_Name = category.sCat_Name;
        //        }
        //        cat.FirstOrDefault().Category_Id = category.category_Id;
        //        entities.SaveChanges();
        //        return true;
        //    }
        //    return false;
        //}
    }
}