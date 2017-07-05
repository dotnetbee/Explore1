using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH.Logger;

namespace CH.Manager
{
    /// <summary>
    /// This class handles the logging 
    /// </summary>
    public class ManagerLogger : ILogger
    {
        /// <summary>
        /// Implement write to log method.
        /// </summary>
        /// <param name="text">The string to write to log.</param>
        public void WriteToLog(string text)
        {
            // Write to Log file
            System.Diagnostics.Trace.WriteLine(string.Format("{0} {1}", DateTime.Now, text));
        }
    }
}
