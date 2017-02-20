using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dictionary = new Dictionary<Type, Type>();

            dictionary.Add(typeof(Domain.Repositories.IToDoRepository), typeof(Repositories.ToDoRepository));

            return dictionary;
        }
    }
}
