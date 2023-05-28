using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.ProductUseCase
{
    public class ViewProductsUseCase : IViewProductsUseCase
    {
        private readonly IProductRepository _prdouctRepository;
        public ViewProductsUseCase(IProductRepository prdouctRepository)
        {

            _prdouctRepository = prdouctRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _prdouctRepository.GetProducts();
        }
    }
}
