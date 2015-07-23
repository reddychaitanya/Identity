using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;


namespace SHIPOS.Identity.Data.Entity
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public Guid CId { get; set; }
        public string Secret { get; set; }
        public string ApiVersion { get; set; }
        public string RedirectUrl { get; set; }
        public string Detail { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
    }
}
