using SocialNet.Domain.Models;

namespace SocialNet.Service.IService
{
    public interface IUserService
    {
        Task<User> GetUser(string Id);
        IEnumerable<User> GetUsers();
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(string Id);
    }
}
