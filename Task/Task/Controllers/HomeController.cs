using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Task.DAL;
using Task.Models;

namespace Task.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Index() { 
            List<Employee> employees = _context.Employees.Include(x=>x.Profession).ToList();
            return View(employees); 
        }
        public ActionResult Contact()
        {
            List<Contact>contacts=_context.Contacts.ToList();
            return View(contacts);
        }
        public ActionResult About()
        {
            List<AboutInfo> aboutInfos = _context.AboutInfos.ToList();
            return View(aboutInfos);
        }
    }
}
