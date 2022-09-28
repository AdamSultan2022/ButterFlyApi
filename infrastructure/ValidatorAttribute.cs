using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ButterFlyApi.Interfaces;
using Microsoft.AspNetCore.Http;

namespace ButterFlyApi.infrastructure
{
    public class ValidatorAttribute: ActionFilterAttribute, IExceptionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            double input1 = 0.0;
            double input2 = 0.0;
            int round = 0;
            if (!double.TryParse(context.ActionArguments["input1"].ToString().TrimEnd().TrimStart(), out input1))
                context.Result = new UnprocessableEntityObjectResult("First input is not a number");

            if (!double.TryParse(context.ActionArguments["input2"].ToString().TrimEnd().TrimStart(), out input2))
                context.Result = new UnprocessableEntityObjectResult("Second input is not a number");

            if (context.RouteData.Values["action"].ToString().ToLower().Contains("withround") && !int.TryParse(context.ActionArguments["round"].ToString().TrimEnd().TrimStart(),out round))
                context.Result = new BadRequestObjectResult("Round parameter is not a number");

            if (context.RouteData.Values["action"].ToString().ToLower().Contains("dividing") && input2 == 0)
                context.Result = new BadRequestObjectResult("You cannot divide number by 0");

            if (context.RouteData.Values["action"].ToString().ToLower().Contains("withround") && round < 0)
                context.Result = new BadRequestObjectResult("Round parameter cannot be less than 0");
            
           
        }
        

        public void OnException(ExceptionContext context)
        {
            context.Result = new ObjectResult(context.Exception.Message) { StatusCode = StatusCodes.Status500InternalServerError };
            context.ExceptionHandled = true;

        }
    }
}
