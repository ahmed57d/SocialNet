using SocialNet.Domain.Models;

namespace SocialNet.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<User> GetUser(string Id);
        IEnumerable<User> GetUsers();
        void InsertUser(User User);
        void UpdateUser(User User);
        void DeleteUser(Guid UserId);
    }
}
