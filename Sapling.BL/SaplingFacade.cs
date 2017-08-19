using SaplingTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaplingBL.BL
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

        public static bool SaveSapling(SaplingsSaveDetails data, Guid loggedUserId)
        {
            return BLSapling.Save(data, loggedUserId);
        }

        public static SaplingDetailViewModal GetSapling(long id, Guid loggedUserId)
        {
            return BLSapling.GetSapling(id, loggedUserId);
        }

        public static List<SaplingViewModal> GetSaplings(Guid loggedUserId, SaplingViewModal saplingViewModal)
        {
            return BLSapling.GetSaplings(loggedUserId, saplingViewModal.Position[0], saplingViewModal.Position[1], saplingViewModal.IsAll);
        }

    }
}
