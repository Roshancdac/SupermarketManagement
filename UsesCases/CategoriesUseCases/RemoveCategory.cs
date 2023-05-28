using UsesCases.DataStorePluginInterfaces;
using UsesCases.UseCaseInterfaces;

namespace UsesCases.CategoriesUseCases
{
    public class RemoveCategory : IRemoveCategory
    {
        private readonly ICategoryRepository _categoryRepository;
        public RemoveCategory(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void RemoveCategoryById(int id)
        {
            _categoryRepository.RemoveCategory(id);
        }
    }
}
