using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.ProductUseCase
{
    public class RemoveProductUseCase : IRemoveProductUseCase
    {
        private readonly IProductRepository _productRepository;
        public RemoveProductUseCase(IProductRepository productRepository)
        {

            _productRepository = productRepository;
        }

        public void Execute(int id)
        {
            _productRepository.RemoveProductById(id);
        }
    }
}
