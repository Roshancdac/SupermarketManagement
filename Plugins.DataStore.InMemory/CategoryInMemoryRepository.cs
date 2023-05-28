using CoreBusniess;
using UsesCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> _listCategories;

        public CategoryInMemoryRepository() {
        
            _listCategories = new List<Category>()
            {
                new Category{ CategoryId = 1, Name = "Beverage", Description = "Beverage"},
                new Category{ CategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category{ CategoryId = 3, Name = "Meat", Description = "Meat"}
            };
        }

        public void AddCategory(Category category)
        {
            if (_listCategories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
                return;

            if (_listCategories != null && _listCategories.Count > 0)
            {
                var maxId = _listCategories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }


             _listCategories?.Add(category);
        }
        public void EditCategory(Category category)
        {
            var UpdatedCategory = _listCategories.Where(I => I.CategoryId== category.CategoryId).FirstOrDefault();

            if (UpdatedCategory != null)
                UpdatedCategory = category;
            else
                AddCategory(category);
        }

        public Category GetCategoryById(int id)
        {
            return _listCategories.Where(I => I.CategoryId == id).FirstOrDefault();
        }

        public IEnumerable<Category> GetCategories()
        {
            return _listCategories;
        }

        public void RemoveCategory(int id)
        {
            var category = GetCategoryById(id);
            if (category != null)
                _listCategories.Remove(category);
        }
    }
}
