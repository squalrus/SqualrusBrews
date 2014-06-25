using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SqualrusBrews.Startup))]
namespace SqualrusBrews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
        }
    }
}
