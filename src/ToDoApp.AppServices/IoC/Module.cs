﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.AppServices.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dictionary = new Dictionary<Type, Type>();

            dictionary.Add(typeof(Interfaces.IToDoAppService), typeof(ToDoAppService));

            return dictionary;
        }
    }
}
