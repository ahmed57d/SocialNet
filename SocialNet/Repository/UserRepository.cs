﻿using Microsoft.EntityFrameworkCore;
using SocialNet.Domain.Models;
using SocialNet.Repository.Contexts;
using SocialNet.Repository.IRepository;

namespace SocialNet.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        string errorMessage = string.Empty;
        public UserRepository(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<User> GetUser(string Id)
        {
            return await context.Users.SingleOrDefaultAsync(s => s.Id == Id)?? new User();
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await context.Users.ToListAsync();
        }

        public void InsertUser(User user)
        {
            context.Users?.Add(user);
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            context.Users?.Update(user);
        }

        public void DeleteUser(string Id)
        {
            context.Remove(Id);
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
