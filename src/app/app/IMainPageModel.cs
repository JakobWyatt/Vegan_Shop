using System;
using System.Collections.Generic;

namespace Vegan_Shop
{
    public interface IMainPageModel
    {
        List<Food> queryFood(String query);
    }
}
