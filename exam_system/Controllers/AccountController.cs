using exam_system.Models;
using exam_system.viewModels;
using Microsoft.AspNetCore.Mvc;

namespace exam_system.Controllers
{
    public class AccountController : Controller
    {
        ExamContext context;
        public AccountController()
        {
            context = new ExamContext();
        }

        [HttpGet]
        public IActionResult Registerion()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registerion(student_reg std)
        {
            Student stud = new Student()
            {
                Id = std.Id,
                Name = std.Name,
                email = std.Email,
                Password = std.Password,
            };
            context.students.Add(stud);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Registerion_ins()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registerion_ins(ins_reg ins_reg)
        {
            Instractor ins = new Instractor()
            {
                Id = ins_reg.Id,
                Name = ins_reg.Name,
                Email = ins_reg.Email,
                Password = ins_reg.Password,
            };
            context.instractors.Add(ins);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Login(log_in loginVM)
        { 
            if (ModelState.IsValid)
            {
                if (loginVM.Id)
                {
                    Instractor ins = context.instractors.FirstOrDefault(s => s.Email == loginVM.Email && s.Password == loginVM.Password);
                    if (ins == null)
                    {
                        ModelState.AddModelError("", "Wrong Email or password");
                        return View(loginVM);
                    }
                    
                    //HttpContext.Session.SetInt32("UserID", ins.Id);
                   // HttpContext.Session.SetString("UserName", ins.Name);
                   // HttpContext.Session.SetString("UserType", "Instractor");
                }
                else
                {
                    Student student = context.students.FirstOrDefault(s => s.email == loginVM.Email && s.Password == loginVM.Password);
                    if (student == null)
                    {
                        ModelState.AddModelError("", "Wrong Email or password");
                        return View(loginVM);
                    }
                    
                   // HttpContext.Session.SetInt32("UserID", student.Id);
                   // HttpContext.Session.SetString("UserName", student.Name);
                   // HttpContext.Session.SetString("UserType", "Student");
                }

                return RedirectToAction("Index", "Home");
            }
            else
            {
                
                return View(loginVM);
            }

        }
    }
    }
