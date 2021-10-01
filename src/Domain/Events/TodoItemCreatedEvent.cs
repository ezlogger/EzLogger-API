using BoardPACLogger.Domain.Common;
using BoardPACLogger.Domain.Entities;

namespace BoardPACLogger.Domain.Events
{
    public class TodoItemCreatedEvent : DomainEvent
    {
        public TodoItemCreatedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
