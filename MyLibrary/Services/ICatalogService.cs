using System;
using System.Collection.Generic;

namespace MyLibrary.Services
{
    public interface ICatalogService
    {
      IEnumerable<Category> GetCategories();
      IEnumerable<Product> GetProducts(int categoryId);

      boo HasInventory(int productId, int quantity);
      void Remove(int productId, int quantity);
    }
}