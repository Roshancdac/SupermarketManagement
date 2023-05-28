using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.ProductUseCase
{
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductRepository _productRepository;
        public GetProductByIdUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetProductById(id);
        }
    }
}
