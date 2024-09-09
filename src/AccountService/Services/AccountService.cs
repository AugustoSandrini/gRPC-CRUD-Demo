using AccountService;
using Grpc.Core;

namespace Service.Services
{
    public class AccountService : Greeter.GreeterBase
    {
        //private readonly ILogger<GreeterService> _logger;
        //public GreeterService(ILogger<GreeterService> logger)
        //{
        //    _logger = logger;
        //}

        public override Task<AccountResponse> SignUp(AccountRequest request, ServerCallContext context)
        {
            return Task.FromResult(new AccountResponse
            {
                AccountId = Guid.NewGuid().ToString(),
                Name = $"{request.FirstName} {request.LastName}",
                Email = request.Email,
                Phone = request.Phone
            });
        }
    }
}
