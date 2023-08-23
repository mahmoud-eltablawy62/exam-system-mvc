using exam_system.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;

namespace exam_system.Controllers
{
    public class StudentController : Controller
    {
        ExamContext Context;

        public StudentController()
        {
            Context = new ExamContext();
        }
       
        public IActionResult Index()
        {         
            List<Student> std = Context.students.ToList();
            return View(std);
        }

        public IActionResult check(List <Student> std)
        {
            int Ma = (int)HttpContext.Session.GetInt32("UserID");
            List <Student> Std = Context.students.ToList();
            for (int i = 0; i < Std.Count; i++) {
                Std[i].choice = std[i].choice;              
                if (Std[i].choice == true)
                
                    {
                        Std[i].ins_id = Ma;
                    }
                }
            Context.SaveChanges();
            return RedirectToAction("index" , "instractor_");
        }


    }
}
