using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Spin.Base.Helper.Base;

namespace Spin.WebSite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TODO:LIST Provider

            SpinProgram Host = new SpinProgram();
            Host.CreateWebHost<Startup>().Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
