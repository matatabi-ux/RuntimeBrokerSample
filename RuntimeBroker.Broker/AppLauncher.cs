using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeBroker.Broker
{
    /// <summary>
    /// Desktop application launcher
    /// </summary>
    [ComVisible(true)]
    public sealed class AppLauncher : IAppLauncher
    {
        /// <summary>
        /// Launch desktop application from file name
        /// </summary>
        /// <param name="fileName">target application executable file name</param>
        public void Launch(string fileName)
        {
            Process.Start(fileName);
        }
    }
}
