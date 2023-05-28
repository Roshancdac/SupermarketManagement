using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.CategoriesUseCases
{
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryByIdUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public Category Execute(int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }
    }
}
