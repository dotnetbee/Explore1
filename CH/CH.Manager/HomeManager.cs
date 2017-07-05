using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH.Logger;

namespace CH.Manager
{
    /// <summary>
    /// This is Home Manager class.
    /// </summary>
    public class HomeManager
    {
        /// <summary>
        /// The constructor for HomeManager
        /// </summary>
        /// <param name="logger">The Logger interface</param>
        public HomeManager(ILogger logger)
        {
            logger.WriteToLog("New Home Manager created");
        }

        /// <summary>
        /// Get the Welcome message
        /// </summary>
        /// <returns>The message string.</returns>
        public string GetWelcomeMessage()
        {
            return "Hello World";
        }
    }
}
