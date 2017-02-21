using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.AppServices.DTOs;
using ToDoApp.DomainServices.Interfaces;
using ToDoApp.AppServices.Extensions;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;

namespace ToDoApp.AppServices
{
    internal class ToDoAppService : Interfaces.IToDoAppService
    {
        private readonly IToDoDomainService _service;

        public ToDoAppService(IToDoDomainService service)
        {
            _service = service;
        }

        public ToDoDTO Create(ToDoDTO toDo)
        {
            return _service.Create(toDo.MapTo<ToDo>()).MapTo<ToDoDTO>();
        }

        public bool Delete(int id)
        {
            return _service.Delete(id);
        }

        public ToDoDTO GetById(int id)
        {
            return _service.GetById(id).MapTo<ToDoDTO>();
        }

        public IEnumerable<ToDoDTO> List(ToDoFilterDTO filter)
        {
            return _service.List(filter.MapTo<ToDoFilter>()).EnumerableTo<ToDoDTO>();
        }

        public bool Update(ToDoDTO toDo)
        {
            return _service.Update(toDo.MapTo<ToDo>());
        }
    }
}
