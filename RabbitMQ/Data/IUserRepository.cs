using UserAPI.Models;

namespace UserAPI.Data
{
    public interface IUserRepository
    {
        Task CreateUser(User user);
        Task DeleteUserAsync(int id);
    }
}
