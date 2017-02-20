using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;

namespace ToDoApp.Domain.Repositories
{
    public interface IToDoRepository
    {
        ToDo Create(ToDo toDo);
        IEnumerable<ToDo> List(ToDoFilter filter);
        ToDo GetById(int id);
        bool Update(ToDo toDo);
        bool Delete(int id);
    }
}
