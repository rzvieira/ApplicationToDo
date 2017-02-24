using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.AppServices.DTOs;
using ToDoApp.AppServices.Interfaces;
using ToDoApp.Extensions;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

//https://github.com/souzara/todoapp﻿

namespace ToDoApp
{
    [Route("api/[controller]")]
    public class ToDoController : Controller
    {
        private readonly IToDoAppService _appService;

        public ToDoController(IToDoAppService appService)
        {
            _appService = appService;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<ToDoDTO> Get([FromQuery] ToDoFilterDTO filter)
        {
            return _appService.List(filter);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ToDoDTO Get(int id)
        {
            return _appService.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public ToDoDTO Post([FromBody]ToDoDTO model)
        {
            return _appService.Create(model);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody]ToDoDTO model)
        {
            return _appService.Update(model);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return _appService.Delete(id);
        }
    }
}
