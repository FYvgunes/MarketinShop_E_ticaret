using System.Collections.Generic;

namespace Market_Uygulaması.Models
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> Drinks { get; set; }
        IEnumerable<Drink> PreferreDrinks { get; set; }
        Drink GetDrinkById(int drinkid);
    }
}