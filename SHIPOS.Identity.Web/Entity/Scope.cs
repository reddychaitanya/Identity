using System;
using System.Collections.Generic;
using System.Text;
using Dapper.Contrib.Extensions;

namespace SHIPOS.Identity.Data.Entity
{
    public class Scope
    {
        [Key]
        public int Id { get; set; }
        public string scope { get; set; }
        public string IsDefault { get; set; }
        public DateTime Created { get; set; }
        public Boolean Status { get; set; }
    }
}
