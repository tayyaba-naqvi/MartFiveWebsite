using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Admin_Panel.Models
{
    public class Item
    {
        string Item_Name = string.Empty;
        int Item_Price = 0;
        string Item_Description = string.Empty;
        int Item_Quantity = 0;
        string Pic_Link = string.Empty;
        string SCat_Name = string.Empty;


        
        [Required]
        [DataType(DataType.Text)]
        public string item_Name { get => Item_Name; set => Item_Name = value; }
        [Required]
        [Range(0,100000, ErrorMessage= "Please enter correct value")]
        public int item_Price { get => Item_Price; set => Item_Price = value; }
        [Required]
        [DataType(DataType.Text)]
        public string item_Description { get => Item_Description; set => Item_Description = value; }
        [Required]
        [Range(0, 100000, ErrorMessage = "Please enter correct value")]
        public int item_Quantity { get => Item_Quantity; set => Item_Quantity = value; }
        [Required]
        [DataType(DataType.Text)]
        public string pic_Id { get => Pic_Link; set => Pic_Link = value; }
        [Required]
        [DataType(DataType.Text)]
        public string sCat_Id { get => SCat_Name; set => SCat_Name = value; }

    }
}