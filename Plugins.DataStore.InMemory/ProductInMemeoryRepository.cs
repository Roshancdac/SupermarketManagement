using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProductInMemeoryRepository : IProductRepository
    {
        private List<Product> _products;
        public ProductInMemeoryRepository()
        {
            _products= new List<Product>()
            {
              new Product { ProductId = 1, CategoryId = 1, Name = "Iced Tea", Quantity = 100 ,Price = 1.99},
              new Product { ProductId = 2, CategoryId = 1, Name = "Canda Dry", Quantity = 200 ,Price = 1.99},
              new Product { ProductId = 3, CategoryId = 2, Name = "Whole Wheat Bread", Quantity = 300 ,Price = 1.99},
              new Product { ProductId = 4, CategoryId = 2, Name = "White Bread", Quantity = 300 ,Price = 1.99}
            };
        }
        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            if (_products.Any(x => x.Name.Equals(product.Name, StringComparison.OrdinalIgnoreCase)))
                return;

            if (_products != null && _products.Count > 0)
            {
                var maxId = _products.Max(x => x.ProductId);
                product.ProductId = maxId + 1;
            }
            else
            {
                product.ProductId = 1;
            }

            _products?.Add(product);
        }

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(Id => Id.ProductId == id);
        }

        public void RemoveProductById(int id)
        {
            var product = GetProductById(id);
            _products.Remove(product);
        }

        public void EditProduct(Product product)
        {
            var updateProduct = _products.Where(i => i.ProductId == product.ProductId).FirstOrDefault();
            if (updateProduct != null)
                updateProduct = product;
        }
    }
}
