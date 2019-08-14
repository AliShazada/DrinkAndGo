using DrinkAndGo.Data.interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    public class DrinkController: Controller
    {
        private readonly ICategoryRepository _catergoryRepository;
        private readonly IDrinkRepository _drinkRepository;

        public DrinkController(ICategoryRepository catergoryRepository, IDrinkRepository drinkRepository)
        {
            _catergoryRepository = catergoryRepository;
            _drinkRepository = drinkRepository;

        }

        public ViewResult List()
        {

            ViewBag.Name = "Dotnet, How ?";

            
            DrinkListViewModel viewmodel = new DrinkListViewModel();
            viewmodel.Drinks = _drinkRepository.Drinks;
            viewmodel.CurrentCategory = "Drink Category";
            
            return View(viewmodel);
        }
    }
}
