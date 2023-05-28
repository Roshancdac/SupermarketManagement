
using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.ProductUseCase
{
    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IProductRepository _product;

        public EditProductUseCase(IProductRepository product)
        {
            _product = product;
        }

        public void Execute(Product product)
        {
            _product.EditProduct(product);
        }
    }
}
