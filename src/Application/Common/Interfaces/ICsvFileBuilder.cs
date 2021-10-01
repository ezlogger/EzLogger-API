using BoardPACLogger.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace BoardPACLogger.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
