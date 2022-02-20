using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace EvOil.WebApi.Infrastructure
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (ValidationException)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            catch (Exception)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            }
        }
    }
}