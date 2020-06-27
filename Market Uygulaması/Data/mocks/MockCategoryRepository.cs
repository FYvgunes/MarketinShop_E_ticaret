using System.Collections.Generic;
using Market_Uygulaması.Models;

namespace Market_Uygulaması.Data.mocks
{
    public class MockCategoryRepository:ICategoryRepository, IDrinkRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                    new Category {CategoryName = "Peynir", Description = "White Chess"},
                };


            }
        }

        public IEnumerable<Drink> Drinks { get; set; }
        public IEnumerable<Drink> PreferreDrinks { get; set; }
        public Drink GetDrinkById(int drinkid)
        {
            throw new System.NotImplementedException();
        }
    }
}