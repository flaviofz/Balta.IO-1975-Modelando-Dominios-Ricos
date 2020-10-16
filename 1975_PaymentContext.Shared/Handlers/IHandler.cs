using _1975_PaymentContext.Shared.Commands;

namespace _1975_PaymentContext.Shared.Handlers
{
    public interface IHandler<T> where T : ICommand
    {
        IcommandResult Handler(T command);
    }
}