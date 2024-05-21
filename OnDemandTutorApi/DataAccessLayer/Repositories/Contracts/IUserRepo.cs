using OnDemandTutorApi.DataAccessLayer.Entity;

namespace OnDemandTutorApi.DataAccessLayer.Repositories.Contracts
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetUsersAsync();
        Task<User> GetByIdAsync();
        Task<User> GetByEmailAndPasswordAsync();
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(User user);
        Task SaveUserAsync(User user);
    }
}
