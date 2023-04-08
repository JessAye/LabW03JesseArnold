using LabW03JesseArnold.Models.Entities;
using LabW03JesseArnold.Services;
using Microsoft.AspNetCore.Mvc;

namespace LabW03JesseArnold.Controllers
{
    public class PersonController : Controller
    {
        
        private readonly IPersonRepository _personRepository;
        public PersonController(IPersonRepository personRepository)
        {

            _personRepository = personRepository;
        }

        
        public IActionResult Index()
        {
            var model = _personRepository.ReadAll();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Person newPerson)
        {
            if (ModelState.IsValid)
            {
                _personRepository.Create(newPerson);
                return RedirectToAction("Index");
            }
            return View(newPerson);
        }

    }
}
