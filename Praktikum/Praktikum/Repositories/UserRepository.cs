using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Praktikum.Repository.entities;
using Praktikum.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum.Repository.Repositories
{
    internal class UserRepository : ICrud<User>
    {
        private readonly IContext context;
        public UserRepository(IContext context)
        {
            this.context = context;
        }

        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> newOne = context.Users.Add(entity);
            await context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task<List<User>> GetAllAsync()
        {
           return await context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await context.Users.FindAsync(id);
        }
    }
}
