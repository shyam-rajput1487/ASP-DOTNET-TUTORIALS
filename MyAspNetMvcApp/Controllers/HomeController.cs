using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using MyAspNetMvcApp.Models;

namespace MyAspNetMvcApp.Controllers;

public class HomeController : Controller
{

   [HttpGet]
   public ViewResult AddEmp()
   {
      return View();
   }
   [HttpPost]
   public ViewResult AddEmp(int? id, string name, string job, double? salary)
   {
      ViewData["Id"] = id;
      ViewData["Name"] = name;
      ViewData["Job"] = job;
      ViewData["Salary"] = salary;
      return View("DisplayEmp1");
   }

[HttpPost]
public ViewResult AddEmp(FormCollection fc)
{
   ViewData["Id"] = fc["id"];
   ViewData["Name"] = fc["name"];
   ViewData["Job"] = fc["job"];
   ViewData["Salary"] = fc["salary"];
   return View("DisplayEmp1");
}


}
