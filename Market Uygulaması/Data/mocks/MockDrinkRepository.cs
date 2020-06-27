using System.Collections.Generic;
using System.Linq;
using Market_Uygulaması.Models;

namespace Market_Uygulaması.Data.mocks
{
    public class MockDrinkRepository : IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Drink> Drinks
        {
            get
            {
                return new List<Drink>
                {
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                    new Drink
                    {
                        Name = "peynir",
                        Price = 7.5EM,
                        ShortDescription = "Deneme",
                        LongDescription = "Denemeadasdasdas",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg",
                        InStoct = true,
                        IsPreferredDrink = true,
                        ImageThumbnailUrl =
                            "https://upload.wikimedia.org/wikipedia/commons/6/61/Trappista_cheese_original.jpg"
                    },
                };
            }
        }

        public IEnumerable<Drink> PreferreDrinks { get; set; }

        public Drink GetDrinkById(int drinkid)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Drink> IDrinkRepository.Drinks { get; set; }
    }
}