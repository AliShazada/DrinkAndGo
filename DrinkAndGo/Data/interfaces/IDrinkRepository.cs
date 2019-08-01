using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.interfaces
{
    interface IDrinkRepository
    {
         IEnumerable<Drink> Drink{ get; set; }

        IEnumerable<Drink> PreferredDrinks { get; set; }

        Drink GetDrinkById (int drinkId );
    }
}
 