using Microsoft.AspNetCore.Mvc;
using Proje.Models;

namespace Proje.Controllers
{
    public class ClinicController : Controller
    {
        public IActionResult Index()
        {
            var candidates = Repository.Applications.ToList(); // List<Candidate> türünde veri döndürür
            return View("Apply/Apply", candidates); // View'e List<Candidate> gönder
        }


        public IActionResult Apply()
        {
            var model = new Candidate(); // Boş bir model oluştur
            return View("Apply/Apply", model); // Modeli View'e gönder
        }


        // public IActionResult Apply() // GET için çalışan method. Eğer başına [Http POST]
        //                              // koymazsak tüm actionlar get ile çalışır.
        // {
        //     var model = Repository.Applications;
        //     return View(model);

        // }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate model) // POST için çalışan method.
                                                               // sunucuya aktaralıcak bu model,  form üzerindeki verilerle doldurulmuştur.buna model binding denir. 
                                                               // bu kısma [] ekleyerek belli bir yerden gelmesini istediğimizi belirtebiliriz. örn:[FromForm]                   
        {
            if (Repository.Applications.Any(c => c.Email.Equals(model.Email))) // parametre ifadeyle email ifadesini karşılaştırıp aynı emaille 
            // birden fazla kayıtı engeller.
            {
                ModelState.AddModelError("", "There is already application for you");
            }
            if (ModelState.IsValid) // modelde değer olduğunda if bloğunu çalıştırır.
            {
                Repository.Add(model);//apply tıklandığında redirect mekanizmasını çalıştırıp
                                      //kök ("/")yani home gitmesini sağlar.
                return View("Feedback", model);
            }
            return View(); // eğer başarısız ise aynı sayfaya dön 
        }

        public IActionResult Login()
        {
            return View("Login/Login");
        }
    }
}