using SocialNet.Domain.Models;

namespace SocialNet.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetUser(string Id);
        Task<IEnumerable<User>> GetUsers();
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(string Id);
        void SaveChanges();
    }
}
