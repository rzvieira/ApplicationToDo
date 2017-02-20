using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ToDoApp.Domain.Entities;
using ToDoApp.Domain.Filters;
using Dapper;

namespace ToDoApp.Data.Repositories
{
    internal class ToDoRepository : RepositoryBase, Domain.Repositories.IToDoRepository
    {
        public ToDoRepository(IConfigurationRoot configuration) 
            : base(configuration)
        {
        }

        public ToDo Create(ToDo toDo)
        {
            toDo.Id = connection.QueryFirst<int>("exec todo_sp_create @Text, @IsCompleted", toDo);

            return toDo;
        }

        public bool Delete(int id)
        {
            var affectedRows = connection.Execute("exec todo_sp_delete @Id", new { Id = id });

            return affectedRows > 0;
        }

        public ToDo GetById(int id)
        {
            var toDo = connection.QueryFirstOrDefault<ToDo>("exec todo_sp_get @Id", new { Id = id });

            return toDo;
        }

        public IEnumerable<ToDo> List(ToDoFilter filter)
        {
            var listToDo = connection.Query<ToDo>("exec todo_sp_list @Id, @Text, @IsCompleted", filter);

            return listToDo;
        }

        public bool Update(ToDo toDo)
        {
            var affectedRows = connection.Execute("exec todo_sp_update. @Id, @Text, @IsCompleted", toDo);

            return affectedRows > 0;
        }
    }
}
