using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleFibo_WebAPI.Models
{
    public class Fibonacci
    {
        //first element
        int f0;
        //second element
        int f1;

        /// <summary>
        /// Constructor: Init Params
        /// </summary>
        public Fibonacci()
        {
            f0 = 0;
            f1 = 1;
        }

        /// <summary>
        /// Calculate Fibonacci Series
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public List<long> Calculate(int length)
        {
            List<long> fibonacci = new List<long>();
            long fsecondlast = f0;
            long flast = f1;
            long fcurrent = 0;

            try
            {

                for (int i = 0; i < length; i++)
                {
                    if (i == 0)
                    {
                        fibonacci.Add(f0);
                        continue;
                    }
                    if (i == 1)
                    {
                        fibonacci.Add(f1);
                        continue;
                    }

                    fcurrent = flast + fsecondlast;
                    fibonacci.Add(fcurrent);

                    fsecondlast = flast;
                    flast = fcurrent;
                }

                return fibonacci;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}