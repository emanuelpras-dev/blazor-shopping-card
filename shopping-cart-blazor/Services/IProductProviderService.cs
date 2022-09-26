using System;
using shopping_cart_blazor.Models;

namespace shopping_cart_blazor.Services
{
    public interface IProductProviderService
    {
        Task<List<Product>> GetProducts();
    }
}

