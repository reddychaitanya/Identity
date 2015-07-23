using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SHIPOS.Identity.Data.Entity
{
    public class Token
    {
        [Key]
        public int Id { get; set; }
        public Guid token { get; set; }
        public Boolean IsRefresh { get; set; }
        public int LoginId { get; set; }
        public int ClientId { get; set; }
        public string Detail { get; set; }
        public DateTime Expires { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
    }
}

