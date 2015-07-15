using SHIPOS.Identity.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPOS.Identity.Data.Repositories
{
    public interface IUserLoginRepository
    {
        List<Login> GetAll();
        Login Get(int id);
        Login Insert(Login user);
        Login Update(Login user);
        void Remove(int id);
        
    }
}
