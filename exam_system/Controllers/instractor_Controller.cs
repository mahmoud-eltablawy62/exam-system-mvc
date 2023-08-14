using exam_system.Models;

using Microsoft.AspNetCore.Mvc;


namespace exam_system.Controllers
{
    public class instractor_Controller : Controller
    {
        ExamContext Context;
        
        public instractor_Controller()
        {
            Context = new ExamContext();
        }
        public IActionResult Index()
        {
                int id =(int) HttpContext.Session.GetInt32("UserID");
                List<Questions> Ques = Context.questions.Where(s => s.ins_id == id ).ToList();
                return View(Ques);     
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Questions qs)
        {
            Questions ques = new Questions()
            {
                Id = qs.Id,
                head = qs.head,
                body = qs.body,
                answer = qs.answer,
                ins_id = HttpContext.Session.GetInt32("UserID"),
            };
            Context.questions.Add(ques);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
       
        [HttpGet]
        public IActionResult Update(int id)
        {
            Questions question = Context.questions.SingleOrDefault(q => q.Id == id );
            return View(question);
        }
        [HttpPost]
        public IActionResult Update(Questions question)
        {
            Questions OldQuestion = Context.questions.SingleOrDefault(q => q.Id == question.Id);
            OldQuestion.head = question.head; 
            OldQuestion.body = question.body;
            OldQuestion.answer = question.answer; 
            
            Context.SaveChanges();         
            return RedirectToAction("Index");
        }

    }
}
