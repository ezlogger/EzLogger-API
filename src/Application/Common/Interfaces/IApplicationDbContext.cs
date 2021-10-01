using BoardPACLogger.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace BoardPACLogger.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoList> TodoLists { get; set; }

        DbSet<TodoItem> TodoItems { get; set; }
        DbSet<Log> Logs { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
