using BoardPACLogger.Domain.Common;
using System.Threading.Tasks;

namespace BoardPACLogger.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
