
using Owin;

using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Logging;
using Thinktecture.IdentityServer.Core.Services;


using SHIPOS.Identity.Web.config;
using Microsoft.AspNet.Builder;
using Microsoft.Framework.Runtime;
using Microsoft.Framework.DependencyInjection;
using SHIPOS.Identity.Data.Repositories;

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
            var certFile = env.ApplicationBasePath + "\\idsrv3test.pfx";

           

            app.Map("/core", core =>
            {
                var factory = InMemoryFactory.Create(
                               
                                clients: Clients.Get(),
                                scopes: Scopes.Get());

                var userService = new UserService();
                factory.UserService = new Registration<IUserService>(resolver => userService);

                var idsrvOptions = new IdentityServerOptions
                {

                    IssuerUri ="",
                    Factory = factory,
                    RequireSsl = false
                   // SigningCertificate = new X509Certificate2(certFile, "idsrv3test")
                };

                core.UseIdentityServer(idsrvOptions);
            });
        }
    }
}
