using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Vegan_Shop
{
    public interface IMainPageModel
    {
        Task<List<Food>> QueryFood(String query);
    }
}
