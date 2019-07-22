using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin_Panel.Models
{
    public class OrderAdmin
    {
        int OL_Id = 0;
        int OL_Price = 0;
        bool OL_Status = false;
        int User_Id = 0;

        public int OL_Id1 { get => OL_Id; set => OL_Id = value; }
        public int OL_Price1 { get => OL_Price; set => OL_Price = value; }
        public bool OL_Status1 { get => OL_Status; set => OL_Status = value; }
        public int User_Id1 { get => User_Id; set => User_Id = value; }

    }
}