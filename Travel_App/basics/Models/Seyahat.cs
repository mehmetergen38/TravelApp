using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basics.Models
{
    public class Seyahat
    {
        public int Id {get; set;}

        public string? Tittle {get; set;}

         public string? Bilgi {get; set;}

         public string? Fiyat {get; set;}

         public string? Image {get; set;}
         
         public string[]? Tags {get; set;}
         public bool isActive;
         public bool isHome;
    }
}