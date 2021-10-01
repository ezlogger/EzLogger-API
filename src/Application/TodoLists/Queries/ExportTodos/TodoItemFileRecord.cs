using BoardPACLogger.Application.Common.Mappings;
using BoardPACLogger.Domain.Entities;

namespace BoardPACLogger.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
