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
        List<UserLogin> GetAll();
        UserLogin Get(int id);
        UserLogin Insert(UserLogin user);
        UserLogin Update(UserLogin user);
        void Remove(int id);
        
    }
}
