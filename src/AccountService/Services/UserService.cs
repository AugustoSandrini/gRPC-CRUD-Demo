using AccountService;
using Grpc.Core;
using Service.Data.Models;

namespace Service.Services
{
    public interface IUserService
    {
        Task<UserResponse> SignIn(SignInRequest request);
        Task<UserResponse> SignUp(SignUpRequest request);
        Task<IEnumerable<User>> GetUsers();
    }

    public class UserService : IUserService
    {
        public Task<IEnumerable<User>> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> SignIn(SignInRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> SignUp(SignUpRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
