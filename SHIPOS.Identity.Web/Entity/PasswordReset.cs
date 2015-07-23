using System;
using Dapper.Contrib.Extensions;

namespace SHIPOS.Identity.Data.Entity
{
    public class PasswordReset
    {
        [Key]
        public int Id { get; set; }
        public int LoginId { get; set; }
        public string Token { get; set; }
        public string Detail { get; set; }
       
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
    }
}
