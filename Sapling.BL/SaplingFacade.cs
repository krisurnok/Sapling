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

        public static long SaveSapling(SaplingsSaveDetails data, Guid loggedUserId)
        {
            return BLSapling.Save(data, loggedUserId);
        }

        public static long UploadImage(Guid loggedUserId,byte[] image)
        {
            SaplingsSaveDetails data = new SaplingsSaveDetails();
            data.Address = string.Empty;
            data.IsExists = true;
            data.Latitude = default(decimal);
            data.Longitude = default(decimal);
            data.NextActionText = string.Empty;
            data.TreeId = 1;
            data.NickName = string.Empty;            

            var saplingId = BLSapling.Save(data, loggedUserId);
            BLSapling.SaveSaplingImages(saplingId, image);
            return saplingId;
        }

        public static SaplingDetailViewModal GetSapling(long id, Guid loggedUserId)
        {
            return BLSapling.GetSapling(id, loggedUserId);
        }

        public static List<SaplingViewModal> GetSaplings(Guid loggedUserId, decimal latitude, decimal longitude, bool isAll = true)
        {
            return BLSapling.GetSaplings(loggedUserId, latitude, longitude, isAll);
        }

    }
}
