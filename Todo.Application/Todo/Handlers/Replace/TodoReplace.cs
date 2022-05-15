using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Application.Todo.Handlers.Replace
{
    public class TodoReplace : TodoInput
    {
        [Required]
        public Guid IdTodo { get; set; }       
    }
}