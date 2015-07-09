using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.ConfigurationModel;
using Thinktecture.IdentityServer.Core.Configuration;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;

namespace SHIPOS.Identity.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDataProtection();
        }

        public void Configure(IApplicationBuilder app, IApplicationEnvironment env)
        {
         app.Map("/core", core =>
            {
                //var factory = InMemoryFactory.Create(
                //                users: Users.Get(),
                //                clients: Clients.Get(),
                //                scopes: Scopes.Get());

                var idsrvOptions = new IdentityServerOptions
                { 
                    Factory = null,
                    RequireSsl = false,
                    SigningCertificate = null,
                    
                };

                core.UseIdentityServer(idsrvOptions);
            });
        }
    }
}
