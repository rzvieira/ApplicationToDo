using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Validators
{
    public class ToDoValidators : AbstractValidator<AppServices.DTOs.ToDoDTO>
    {
        public ToDoValidators()
        {
            RuleFor(r => r.Text).NotNull().WithMessage("Text field is required.");
        }
    }
}
