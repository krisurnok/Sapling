using Sapling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapling.BL
{
    public class SaplingFacade
    {
        /// <summary>
        /// Name       :GetUser
        /// Discription:Get user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static User GetUser(Guid id)
        {
            if (id == Guid.Empty)
                return null;

            return BLUser.Get(id);
        }

        public  static List<SaplingViewModal> GetSaplings(Guid loggedUserId, SaplingViewModal saplingViewModal)
        {
            try
            {
                return BLSapling.GetSaplings(loggedUserId, saplingViewModal.Position[0], saplingViewModal.Position[1], saplingViewModal.IsAll);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
