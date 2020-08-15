using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text;
using System.Net;
using System.Web.Script.Serialization;

namespace FiboAPI_ConsoleClient
{
    class Program
    {
        /// <summary>
        /// Main: Accept Input & call API
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
        Start:
            try
            {
                Console.Write("Enter length for Fibonacci series: ");
                int len = Convert.ToInt32(Console.ReadLine());

                //set WebAPI URL
                string apiUrl = "http://localhost:26404/api/FibonacciAPI";
                var input = new
                {
                    Length = len,
                };

                WebClient client = new WebClient();
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string inputJson = (new JavaScriptSerializer()).Serialize(input);

                // Call webAPI
                string json = client.UploadString(apiUrl + "/GetFibonacci", inputJson);

                List<long> fibonacci = (new JavaScriptSerializer()).Deserialize<List<long>>(json);

                if (fibonacci.Count > 0)
                {
                    foreach (long value in fibonacci)
                    {
                        Console.WriteLine(value);
                    }
                }
                else
                {
                    Console.WriteLine("No records found.");
                }

                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            goto Start;
        }

    }
}
