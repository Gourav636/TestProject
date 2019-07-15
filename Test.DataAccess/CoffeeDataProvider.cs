using System.Collections.Generic;
using Test.DataAccess.Model;

namespace Test.DataAccess
{
    public class CoffeeDataProvider
    {
        public IEnumerable<CoffeeShop> LoadcoffeeShops()
        {
            yield return new CoffeeShop { Location = "Banaglore", BeanStock = 72 };
            yield return new CoffeeShop { Location = "Mumbai", BeanStock = 52 };
            yield return new CoffeeShop { Location = "Goa", BeanStock = 12 };
        }
    }
}
