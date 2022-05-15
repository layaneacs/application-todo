using System;
using System.Collections.Generic;
using System.Linq;
using Todo.Domain.Repository;
using Todo.Domain.Todo;

namespace Todo.Infra.Todo.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private static List<TodoModel> listaMockada = new List<TodoModel>();        

        public TodoRepository()
        {
        }
        public List<TodoModel> GetAll()
        {
            return listaMockada;
        }

        public bool Save(TodoModel todo)
        {            
            try{
                listaMockada.Add(todo);
                return true;
            } catch {
                return false;
            }            
        }
        public TodoModel GetById(string guid)
        {
            var todo = listaMockada.Where(x => x.Id == System.Guid.Parse(guid)).FirstOrDefault();
            return todo;
        }

        public TodoModel GetById(Guid guid)
        {
            var todo = listaMockada.FirstOrDefault(x => x.Id == guid);
            return todo;
        }

        public bool Replace (TodoModel todo)
        {
            var indice = listaMockada.FindIndex(x => x.Id == todo.Id);            
            if(indice >= 0)
            {
                listaMockada[indice] = todo;
                return true;
            }  
            return false;
        }    
    }
}

 