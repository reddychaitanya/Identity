using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace SHIPOS.Identity.Data.Entity
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        public Guid DomainKey { get; set; }
        public string Email { get; set; }
        public Guid EmailToken { get; set; }
        public string EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int LockoutMax { get; set; }
        public int LoutoutFailCount { get; set; }
        public DateTime LockoutEnds { get; set; }
        public string Detail { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }

        public List<Claim> Claims
        {
            get
            {
                List<Claim> _claims = new List<Claim>();
                _claims.Add(new Claim("sub", "sub"));
                _claims.Add(new Claim("email", "email"));
                return _claims;
            }
        }
    }
}