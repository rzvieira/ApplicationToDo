using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.AppServices.DTOs
{
    public class ToDoDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCompleted { get; set; }
    }
}
