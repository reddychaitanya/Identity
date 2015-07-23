using Microsoft.AspNet.Builder;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Framework.Runtime;
using Owin;
using SHIPOS.Identity.Data.Repositories;
using SHIPOS.Identity.Web.config;
using Thinktecture.IdentityServer.Core.Configuration;
using Thinktecture.IdentityServer.Core.Logging;
using Thinktecture.IdentityServer.Core.Logging.LogProviders;
using Thinktecture.IdentityServer.Core.Services;

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
                // factory.ViewService = new Registration<IViewService>(typeof(CustomViewService));

                var idsrvOptions = new IdentityServerOptions
                {
                    IssuerUri = "",
                    Factory = factory,
                    RequireSsl = false,
                    LoggingOptions =
                    // SigningCertificate = new X509Certificate2(certFile, "idsrv3test")
                };

                core.UseIdentityServer(idsrvOptions);
            });
        }
    }
}