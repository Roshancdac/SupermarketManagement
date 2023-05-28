using CoreBusniess;

namespace UsesCases.UseCaseInterfaces
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int id);
    }
}