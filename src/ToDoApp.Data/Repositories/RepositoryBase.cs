﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ToDoApp.Data.Repositories
{
    internal class RepositoryBase
    {
        // senha = Uh90U1hW4_?l

        // mssql5.gear.host - todoapp3

        private const string CONNECTIONSTRING_KEY = "ConnectionString";

        protected SqlConnection connection;

        public RepositoryBase(IConfigurationRoot configuration)
        {   
            var connectionString = configuration.GetSection(CONNECTIONSTRING_KEY);

            if (string.IsNullOrWhiteSpace(connectionString.Value))
            {
                throw new ArgumentNullException("Connection string not found");
            }

            connection = new SqlConnection(connectionString.Value);
        }
    }
}
