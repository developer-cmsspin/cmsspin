using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Spin.Base.Helper.Base;

namespace Spin.WebSite
{
    /// <summary>
    /// Program Init
    /// </summary>
    public class Program : SpinProgram<Startup>
    {
        /// <summary>
        /// Main Call
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            CallMain(args);
        }

    }
}
