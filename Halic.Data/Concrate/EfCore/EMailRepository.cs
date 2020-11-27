using Halic.Data.Abstract;
using Halic.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Halic.Data.Concrate.EfCore
{
    public class EMailRepository : GenericRepository<EMail, HalicContext>, IEMailRepository
    {
        public EMail GetByEmail(string email)
        {
            using (var context = new HalicContext())
            {
                EMail ct;
                return ct = context.EMails.Where(i => i.Email == email).FirstOrDefault();

            }
        }
    }
}
