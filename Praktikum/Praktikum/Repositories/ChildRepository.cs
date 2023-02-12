using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using Praktikum.Repository.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Praktikum.Repository.Interface;

namespace Praktikum.Repository.Repositories
{
    internal class ChildRepository:ICrud<Child>
    {
        private readonly IContext context;
        public ChildRepository(IContext context)
        {
            this.context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> newOne = context.Children.Add(entity);
            await context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await context.Children.FindAsync(id);
        }
    }
}
