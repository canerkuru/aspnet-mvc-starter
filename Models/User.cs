using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aspnet_mvc_starter.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserEMail { get; set; }
        public string UserTitle { get; set; }
    }
}