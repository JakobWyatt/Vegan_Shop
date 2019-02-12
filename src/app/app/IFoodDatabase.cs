using System.Threading.Tasks;
using System.Collections.Generic;

namespace Vegan_Shop
{
    public interface IFoodDatabase
    {
        Task<List<Food>> GetFoods();
        void Update();
    }
}
