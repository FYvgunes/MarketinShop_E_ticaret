using System.Security.Principal;
using Market_Uygulaması.Models;
using Microsoft.AspNetCore.Mvc;

namespace Market_Uygulaması.Controllers
{
    public class DrinkController : Controller
    {

        private readonly ICategoryRepository _categoryRepository;
        private readonly IDrinkRepository _drinkRepository;
        public DrinkController(ICategoryRepository categoryRepository, IDrinkRepository drinkRepository)
        {
            _categoryRepository = categoryRepository;
            _drinkRepository = drinkRepository;

        }

        public IActionResult List()
        {
            var drinks = _drinkRepository.Drinks;
            return View(drinks);
        }
    }
}