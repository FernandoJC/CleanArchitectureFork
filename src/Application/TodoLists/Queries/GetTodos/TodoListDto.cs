using CleanArchitectureSolutionTemplate.Application.Common.Mappings;
using CleanArchitectureSolutionTemplate.Domain.Entities;
using System.Collections.Generic;

namespace CleanArchitectureSolutionTemplate.Application.TodoLists.Queries.GetTodos
{
    public class TodoListDto : IMapFrom<TodoList>
{
    public TodoListDto()
    {
        Items = new List<TodoItemDto>();
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public IList<TodoItemDto> Items { get; set; }
}
}
