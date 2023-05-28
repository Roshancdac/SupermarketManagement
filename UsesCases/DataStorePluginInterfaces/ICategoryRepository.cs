using CoreBusniess;


namespace UsesCases.DataStorePluginInterfaces
{
    public interface ICategoryRepository
    {
        public IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void EditCategory(Category category);
        Category GetCategoryById(int id);
        void RemoveCategory(int id);
    }
}
