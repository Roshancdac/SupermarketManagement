using CoreBusniess;

namespace UsesCases.UseCaseInterfaces
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int id);
    }
}