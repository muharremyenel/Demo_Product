﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Şehir Boş Bırakılamaz");
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("İsim Boş Bırakılamaz");
        }
    }
}
