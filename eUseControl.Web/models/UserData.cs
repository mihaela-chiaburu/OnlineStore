using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.Web.Models.User
{
    public class UserData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Products { get; set; }
        public string SingleProduct { get; set; }


    }
}