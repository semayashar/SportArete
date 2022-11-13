﻿using SportArete.Core.Models.Product;
using SportArete.Infrastructure.Data.Models;

namespace SportArete.Core.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        Task<IEnumerable<Brand>> GetBrandsAsync();
        Task AddProductAsync(AddProductViewModel model);

        Task<IEnumerable<ProductViewModel>> GetTopAsync();
        Task<IEnumerable<ProductViewModel>> GetAllAsync();

        Task<Product> GetDetailedProductAsync(int productId);
    }
}
