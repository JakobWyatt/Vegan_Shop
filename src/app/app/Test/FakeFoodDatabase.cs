using System.Collections.Generic;
using System.Threading.Tasks;
using Vegan_Shop;

namespace Vegan_Shop_Test
{
    //This class implements IFoodDatabase, but does not use a database at all
    public class FakeFoodDatabase : IFoodDatabase
    {
        public void Update() { }

        public Task<List<Food>> GetFoods()
        {
            return Task.FromResult(TestData.TestFood);
        }
    }
}
