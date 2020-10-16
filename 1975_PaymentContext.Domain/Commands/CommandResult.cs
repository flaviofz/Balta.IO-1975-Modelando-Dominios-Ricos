using _1975_PaymentContext.Shared.Commands;

namespace _1975_PaymentContext.Domain.Commands
{
    public class CommandResult : IcommandResult
    {
        public CommandResult()
        {

        }

        public CommandResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}