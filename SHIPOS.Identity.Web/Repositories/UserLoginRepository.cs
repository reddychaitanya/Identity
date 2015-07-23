using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DapperExtensions;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using SHIPOS.Identity.Data.Entity;

namespace SHIPOS.Identity.Data.Repositories
{
    public class UserLoginRepository
    {
        private IDbConnection _db = new SqlConnection("Data Source=192.168.1.241\\sqlexpress;Initial Catalog=identity;user id=sa;password=Aa123456;");

        public Login Get(int id)
        {
            return this._db.Query<Login>("SELECT * FROM UserLogin WHERE Id = @Id", new { id }).SingleOrDefault();
        }

        public IEnumerable<Login> GetAll()
        {
            return this._db.Query<Login>("SELECT * FROM Login");
        }

        public Login GetUserByEmail(string Email)
        {
            return this._db.Query<Login>("SELECT * FROM Login where Email = @email", new { Email }).SingleOrDefault();
        }

        public int Insert(Login userLogin)
        {
            dynamic result = _db.Insert(userLogin, null, null);
            return result;
        }

        public int Update(Login userLogin)
        {
            return 0;
        }
        }
}
