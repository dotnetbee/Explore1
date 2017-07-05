using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH.Logger
{
    /// <summary>
    /// This is ILogger interface 
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// write to log
        /// </summary>
        /// <param name="text"></param>
        void WriteToLog(string text);
    }
}
