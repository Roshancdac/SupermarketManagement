using CoreBusniess;

namespace UsesCases.DataStorePluginInterfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
        Product GetProductById(int id);
        void RemoveProductById(int id);
        void EditProduct(Product product);
    }
}
