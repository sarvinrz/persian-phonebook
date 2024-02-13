using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCphoneBook.Models.EntityModels
{
    public class TblUsers
    {
       
        public int ID { get; set; }
        [Display(Name = "نام")]
        public string Name { get; set; }
        [Display(Name = " نام خانوادگی")]
        public string FamilyName { get; set; }
        [Display(Name = "تلفن همراه")]
        public string Mobile { get; set; }
        [Display(Name = "تلفن ثابت")]
        public string PhoneNumber { get; set; }
        [Display(Name = "کد ملی")]
        public string NationalCode { get; set; }
        [Display(Name = "موقعیت شغلی")]
        public string OrgPos { get; set; }
    }
}

namespace MVCphoneBook.Models.DominModels
{
    [MetadataType(typeof(EntityModels.TblUsers))]
    public partial class TblUser
    {

    }
}