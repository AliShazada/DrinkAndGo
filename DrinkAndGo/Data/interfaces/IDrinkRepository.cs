using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.interfaces
{
    interface IDrinkRepository
    {
         IEnumerable<Drink> Drink{ get;  }

        IEnumerable<Drink> PreferredDrinks { get;  }

        Drink GetDrinkById (int drinkId );
    }
}
 