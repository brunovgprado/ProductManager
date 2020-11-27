using Microsoft.AspNetCore.Mvc;
using ProductManager.Application.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManager.Api.Contracts
{
    public interface IActionResultConverter
    {
        IActionResult Convert<T>(Response<T> response);
    }
}
