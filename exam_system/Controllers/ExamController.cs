using exam_system.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.RegularExpressions;

namespace exam_system.Controllers
{
    public class ExamController : Controller
    {
       

        ExamContext Context;

        public ExamController()
        {
            Context = new ExamContext();
        }

        
        public IActionResult Index()
        {
           
            return View();
        }


        public IActionResult Check()
        {
            var id = (int)HttpContext.Session.GetInt32("UserID");
            List<Student> std = Context.students.ToList();
            var quary = std.Where(s => s.Id == id).SingleOrDefault();
            List<Questions> Ques = Context.questions.Where(s => s.ins_id == quary.ins_id).ToList();
            return View(Ques);
        }

        public IActionResult result( List <Questions> Qs )
        {
            var id = (int)HttpContext.Session.GetInt32("UserID");
            Student std = Context.students.SingleOrDefault(q => q.Id == id);
            
            List<Questions> Ques = Context.questions.Where(s => s.ins_id == std.ins_id).ToList();
            Console.WriteLine(Qs[0].answer_stud);
            Console.WriteLine(Ques[0].answer);
            int y = std.grade ; 
            
            for ( int i = 0; i < Qs.Count; i++)
            {
                if (Qs[i].answer_stud == Ques[i].answer)
                {
                     std.grade = ++y;
                }
            }
            Console.WriteLine(y);
            Context.SaveChanges();  

            
            return View("Index");

        }


    }
}
