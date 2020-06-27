using System.Collections.Generic;

namespace Market_Uygulaması.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}