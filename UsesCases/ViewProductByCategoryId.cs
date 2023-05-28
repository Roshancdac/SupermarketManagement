using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases
{
    public class ViewProductByCategoryId : IViewProductByCategoryId
    {
        public IProductRepository _productRepository { get; set; }
        public ViewProductByCategoryId(IProductRepository productRepository)
        {

            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetProductByCategoryId(int id)
        {
            return _productRepository.GetProducts().Where(Id => Id.CategoryId == id).ToList();
        }
    }
}
