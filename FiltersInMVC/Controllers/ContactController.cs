using FiltersInMVC.Data.Repository;
using FiltersInMVC.Models;
using FiltersInMVC.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using FiltersInMVC.Filters;
using Microsoft.AspNetCore.Authorization;

namespace FiltersInMVC.Controllers
{
    //[AllowAnonymous]
    //[ValidateAntiForgeryToken]
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;
        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contactRepository.CreateAsync(model);
                    
                    ViewBag.Message = "Thank you! Your message has been sent.";
                }
                catch(Exception ex)
                {
                    ViewBag.Message = ex.Message;

                }   
                
                ModelState.Clear();
            }
            return View();
        }        
    }
}
