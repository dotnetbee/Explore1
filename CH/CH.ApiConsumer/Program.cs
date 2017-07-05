using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace CH.ApiConsumer
{
    /// <summary>
    /// This is API consumer class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This function consumens API and displays message on the screen.
        /// </summary>
        /// <param name="args">The event arguments.</param>
        static void Main(string[] args)
        {
            try
            {
                HttpClient cons = new HttpClient();

                // Get Base address from Configuration file. 
                string baseAddress = Convert.ToString(ConfigurationManager.AppSettings["BaseAddress"]);

                if (string.IsNullOrWhiteSpace(baseAddress))
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------Warning------------------");
                    Console.WriteLine("Please Enter Base Address in app.config.");
                    Console.WriteLine("----------------------------------------");
                    Console.ReadLine();
                    return;
                }

                cons.BaseAddress = new Uri(baseAddress);
                cons.DefaultRequestHeaders.Accept.Clear();
                cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                GetWelcomeMessage(cons).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Following Exception has been reported:");
                Console.WriteLine("\n");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        /// <summary>
        /// This function calls API to get welcome message.
        /// </summary>
        /// <param name="cons">The HttpClient object.</param>
        /// <returns>Returns Task instance.</returns>
        static async Task GetWelcomeMessage(HttpClient cons)
        {
            using (cons)
            {
                // Call to /api/Home 
                HttpResponseMessage res = await cons.GetAsync("api/Home");
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    string message = await res.Content.ReadAsAsync<string>();
                    Console.WriteLine("\n");
                    Console.WriteLine("---------------------Calling Get Operation------------------------");
                    Console.WriteLine("\n");
                    Console.WriteLine("Welcome Message");
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine("\t\t{0}\t\t", message);
                    Console.ReadLine();
                }
            }
        }
    }
}
