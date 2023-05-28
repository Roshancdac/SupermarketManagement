using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;

namespace UsesCases.UseCaseInterfaces
{
    public interface IViewProductByCategoryId
    {
        IProductRepository _productRepository { get; set; }

        IEnumerable<Product> GetProductByCategoryId(int id);
    }
}