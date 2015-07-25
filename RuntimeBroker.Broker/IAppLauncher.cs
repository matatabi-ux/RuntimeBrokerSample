using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RuntimeBroker.Broker
{
    /// <summary>
    /// Desktop Application launcher interfce
    /// </summary>
    [ComVisible(true)]
    public interface IAppLauncher
    {
        /// <summary>
        /// Launch desktop application from file name
        /// </summary>
        /// <param name="fileName">target application executable file name</param>
        void Launch(string fileName);
    }
}
