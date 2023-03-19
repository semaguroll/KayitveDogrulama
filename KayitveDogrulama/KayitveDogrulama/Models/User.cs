using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KayitveDogrulama.Models
{
    public class User
    {
        public long TCNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; }
    }
}