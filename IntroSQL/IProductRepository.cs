using System;
using System.Collections.Generic;

namespace IntroSQL
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts();
    }
}
