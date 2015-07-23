using Dapper;
using SHIPOS.Identity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPOS.Identity.Data.Repositories
{
    public class ClientRepository
    {
        private IDbConnection _db = new SqlConnection("Data Source=192.168.1.241\\sqlexpress;Initial Catalog=identity;user id=sa;password=Aa123456;");

        public ClientRepository()
        {
        }

        public List<Client> GetAll()
        {
            return this._db.Query<Client>("SELECT * FROM Client").ToList();
        }

       
    }
}

