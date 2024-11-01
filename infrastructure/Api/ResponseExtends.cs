﻿using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure.Api
{
    public static class ResponseExtends
    {
        public static IActionResult GetActionResult(this Response response)
        {
            if (response == null)
                return new BadRequestObjectResult("Sin respuesta");

            if (response.Success)
                return new OkObjectResult(response);
            else
                return new BadRequestObjectResult(response);
        }

        public static IActionResult GetActionResult<T>(this Response<T> response)
            where T : class
        {
            if (response == null)
                return new BadRequestObjectResult("Sin respuesta");

            if (response.Success)
                return new OkObjectResult(response);
            else
                return new BadRequestObjectResult(response);
        }
    }
}
