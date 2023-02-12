using Microsoft.EntityFrameworkCore;
using Praktikum.Repository.entities;
using System.Collections.Generic;

namespace Praktikum.Repository
{
    public interface IContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Child> Children { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}