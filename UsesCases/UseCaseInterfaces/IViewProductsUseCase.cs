using CoreBusniess;

namespace UsesCases.UseCaseInterfaces
{
    public interface IViewProductsUseCase
    {
        IEnumerable<Product> Execute();
    }
}