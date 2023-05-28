using CoreBusniess;

namespace UsesCases.UseCaseInterfaces
{
    public interface IViewCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}