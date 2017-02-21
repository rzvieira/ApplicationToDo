using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;
using ToDoApp.Domain.Repositories;

namespace ToDoApp.DomainServices
{
    internal class ToDoDomainServices : Interfaces.IToDoDomainService
    {
        private readonly IToDoRepository _repository;

        public ToDoDomainServices(IToDoRepository repository)
        {
            _repository = repository;
        }

        public ToDo Create(ToDo toDo)
        {
            return _repository.Create(toDo);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public ToDo GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<ToDo> List(ToDoFilter filter)
        {
            return _repository.List(filter);
        }

        public bool Update(ToDo toDo)
        {
            return _repository.Update(toDo);
        }
    }
}
