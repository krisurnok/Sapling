using Sapling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapling.BL
{
    internal class BLSapling
    {
        public static void GetSaplings(Guid loggedUserId,decimal latitude, decimal longitude,bool isAll=true)
        {
            try
            {
                using (saplingEntities saplingEntites = new saplingEntities())
                {
                   saplingEntites.Sapling.Where(w=>w.)
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
