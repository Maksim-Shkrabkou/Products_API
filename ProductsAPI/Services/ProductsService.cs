using System.Collections.Generic;
using ProductsAPI.Model;

namespace ProductsAPI.Services
{
    public class ProductsService : IProductsService
    {
        private List<Product> _productItem;

        public ProductsService()
        {
            _productItem = new List<Product>();
        }

        public List<Product> GetProducts()
        {
            return _productItem;
        }

        public Product AddProduct(Product productItem)
        {
            _productItem.Add(productItem);

            return productItem;
        }

        public Product UpdateProduct(string id, Product productItem)
        {
            for (var i = 0; i < _productItem.Count; i++)
            {
                if (_productItem[i].ID == id)
                {
                    _productItem[i] = productItem;
                }
            }

            return productItem;
        }

        public string DeleteProduct(string id)
        {
            for (var i = 0; i < _productItem.Count; i++)
            {
                if (_productItem[i].ID == id)
                {
                    _productItem.RemoveAt(i);
                }
            }

            return id;
        }
    }
}
