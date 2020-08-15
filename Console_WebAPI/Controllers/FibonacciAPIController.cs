using ConsoleFibo_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Linq;

namespace ConsoleFibo_WebAPI.Controllers
{
    public class FibonacciAPIController : ApiController
    {
        /// <summary>
        /// Get Fibonacci Series
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [Route("api/FibonacciAPI/GetFibonacci")]
        [HttpPost]
        public List<long> GetFibonacci(FibonacciModel model)
        {
            Fibonacci fibonacci = new Fibonacci();
            return fibonacci.Calculate(model.Length);
        }
    }
}
