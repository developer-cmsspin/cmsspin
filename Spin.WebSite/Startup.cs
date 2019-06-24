using Microsoft.Extensions.Configuration;
using Spin.Base.Company.Entity;
using Spin.Base.Helper.Base;
using Spin.Geolocation.MaxMind.API;


namespace Spin.WebSite
{
    /// <summary>
    /// Startup.
    /// </summary>
    public class Startup : SpinStartup
    {

        #region Startup
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Spin.WebSite.Startup"/> class.
        /// </summary>
        /// <param name="configuration">Configuration.</param>
        public Startup(IConfiguration configuration)
            : base(configuration)
        {
            

        }
        #endregion
    }

}
