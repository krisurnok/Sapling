using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sapling.Model;

namespace Sapling.BL
{
    internal class BLUser
    {
        internal static User Get(Guid id)
        {
            try
            {
                User _user = null;
                using (saplingEntities sapling = new saplingEntities())
                {
                    _user =sapling.User.First(w => w.Id == id);
                }
                return _user;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
