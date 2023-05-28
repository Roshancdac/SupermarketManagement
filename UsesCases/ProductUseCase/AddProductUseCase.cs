using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.ProductUseCase
{
    public class AddProductUseCase : IAddProductUseCase
    {
        public IProductRepository _productRepository { get; }
        public AddProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        void IAddProductUseCase.Execute(Product product)
        {
            _productRepository.AddProduct(product);
        }
    }
}
