using SocialNet.Domain.Models;
using SocialNet.Repository.IRepository;
using SocialNet.Service.IService;

namespace SocialNet.Service
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        

        public Task<User> GetUser(string Id)
        {
            return userRepository.GetUser(Id);
        }

        public Task<IEnumerable<User>> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public void InsertUser(User user)
        {
            userRepository.InsertUser(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUser(user);
        }
        public void DeleteUser(string id)
        {
            userRepository.DeleteUser(id);
        }
    }
}
