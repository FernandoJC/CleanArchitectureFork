using CleanArchitectureSolutionTemplate.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace CleanArchitectureSolutionTemplate.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
