using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers
{
    public class TravelController : Controller
    {
       

     public IActionResult Seyahat(){

     
        return View("Seyahat",Repository.Seyahats);
      }
      public IActionResult Details(int? id){

        if(id== null){
          return Redirect("/Travel/Seyahat");
        }
           var işlem = Repository.GetById(id);

      
        return View(işlem);     
      
      }

    }
}