using SHIPOS.Identity.Data.Entity;
using SHIPOS.Identity.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Thinktecture.IdentityServer.Core.Models;
using Thinktecture.IdentityServer.Core.Services;

namespace SHIPOS.Identity.Web
{
    public class UserService : IUserService
    {
        public Guid DomainKey { get; set; }
        public static Login login = new Login();

        public Task<AuthenticateResult> AuthenticateExternalAsync(ExternalIdentity externalUser, SignInMessage message)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        public Task<AuthenticateResult> AuthenticateLocalAsync(string email, string password, SignInMessage message)
        {
            //authenticate
            UserLoginRepository userLoginRepository = new UserLoginRepository();
            login = userLoginRepository.GetUserByEmail(email);
            if (login == null)
            {
                return Task.FromResult<AuthenticateResult>(null);
            }

            return Task.FromResult<AuthenticateResult>(new AuthenticateResult(login.DomainKey.ToString(), login.Email));
        }

        public Task<IEnumerable<System.Security.Claims.Claim>> GetProfileDataAsync(ClaimsPrincipal subject, IEnumerable<string> requestedClaimTypes = null)
        {
            return Task.FromResult<IEnumerable<Claim>>(login.Claims);
        }

        public Task<bool> IsActiveAsync(ClaimsPrincipal subject)
        {
            var user = login;
            return Task.FromResult(user != null);
        }

        public Task<AuthenticateResult> PreAuthenticateAsync(SignInMessage message)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        public Task SignOutAsync(ClaimsPrincipal subject)
        {
            return Task.FromResult(0);
        }
    }
}