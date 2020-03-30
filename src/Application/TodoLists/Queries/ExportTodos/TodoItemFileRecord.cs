using CleanArchitectureSolutionTemplate.Application.Common.Mappings;
using CleanArchitectureSolutionTemplate.Domain.Entities;

namespace CleanArchitectureSolutionTemplate.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
