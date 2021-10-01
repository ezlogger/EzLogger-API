using BoardPACLogger.Domain.Common;
using BoardPACLogger.Domain.Entities;

namespace BoardPACLogger.Domain.Events
{
    public class TodoItemCompletedEvent : DomainEvent
    {
        public TodoItemCompletedEvent(TodoItem item)
        {
            Item = item;
        }

        public TodoItem Item { get; }
    }
}
