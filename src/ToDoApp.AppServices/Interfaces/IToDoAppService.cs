using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.AppServices.DTOs;

namespace ToDoApp.AppServices.Interfaces
{
    public interface IToDoAppService
    {
        ToDoDTO Create(ToDoDTO toDo);
        IEnumerable<ToDoDTO> List(ToDoFilterDTO filter);
        ToDoDTO GetById(int id);
        bool Update(ToDoDTO toDo);
        bool Delete(int id);
    }
}
