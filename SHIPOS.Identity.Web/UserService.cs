using SHIPOS.Identity.Data.Entity;
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
        public static List<UserLogin> Users = new List<UserLogin>();

        public Task<AuthenticateResult> AuthenticateExternalAsync(ExternalIdentity externalUser, SignInMessage message)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        public Task<AuthenticateResult> AuthenticateLocalAsync(string email, string password,  SignInMessage message)
        {

            //authenticate
            var user = Users.SingleOrDefault(x => x.Email == email &&  x.DomainKey == this.DomainKey);
            if (user == null)
            {
                return Task.FromResult<AuthenticateResult>(null);
            }

            return Task.FromResult<AuthenticateResult>(new AuthenticateResult(user.DomainKey.ToString(), user.Email));
        }

        public Task<IEnumerable<System.Security.Claims.Claim>> GetProfileDataAsync(ClaimsPrincipal subject, IEnumerable<string> requestedClaimTypes = null)
        {
            throw new NotImplementedException();
            //// issue the claims for the user
            //var user = Users.SingleOrDefault(x => x.DomainKey == subject.GetSubjectId());
            //if (user == null)
            //{
            //    return Task.FromResult<IEnumerable<Claim>>(null);
            //}

            //return Task.FromResult(user.Claims.Where(x => requestedClaimTypes.Contains(x.Type)));
        }

        public Task<bool> IsActiveAsync(ClaimsPrincipal subject)
        {
            throw new NotImplementedException();
            //var user = Users.SingleOrDefault(x => x.Subject == subject.GetSubjectId());
            //return Task.FromResult(user != null);
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
