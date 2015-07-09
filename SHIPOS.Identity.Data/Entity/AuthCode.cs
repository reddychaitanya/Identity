using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SHIPOS.Identity.Data.Entity
{
    public class AuthCode
    {
        [Key]
        public int Id { get; set; }
        public Guid Authcode { get; set; }
        public int LoginId { get; set; }
        public int ClientId { get; set; }
        public DateTime Expires { get; set; }
        public String Detail { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
        

    }
}
