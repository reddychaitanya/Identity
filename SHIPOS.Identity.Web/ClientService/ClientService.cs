using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SHIPOS.Identity.Web.ClientService
{
    public class ClientService
    {

        public IEnumerable<Thinktecture.IdentityServer.Core.Models.Client> GetAll()
        {
            IEnumerable<Thinktecture.IdentityServer.Core.Models.Client> thinkTectureClient = null;

            //get shipos client and convert to thinktecture client
            return thinkTectureClient;

            
        }


    }
}
