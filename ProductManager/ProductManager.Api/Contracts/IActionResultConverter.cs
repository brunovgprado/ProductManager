using Microsoft.AspNetCore.Mvc;
using ProductManager.Application.Shared;

namespace ProductManager.Api.Contracts
{
    public interface IActionResultConverter
    {
        IActionResult Convert<T>(Response<T> response);
    }
}
