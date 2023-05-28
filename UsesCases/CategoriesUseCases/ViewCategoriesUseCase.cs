using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.CategoriesUseCases
{
    public class ViewCategoriesUseCase : IViewCategoriesUseCase
    {
        private readonly ICategoryRepository _categoryRepository;
        public ViewCategoriesUseCase(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> Execute()
               => _categoryRepository.GetCategories();
    }
}
