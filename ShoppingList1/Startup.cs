using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoppingList1.Startup))]
namespace ShoppingList1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
