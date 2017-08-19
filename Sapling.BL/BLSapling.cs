using SaplingTree.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaplingBL.BL
{
    internal class BLSapling
    {
        public static List<SaplingViewModal> GetSaplings(Guid loggedUserId, decimal latitude, decimal longitude, bool isAll = true)
        {
            try
            {
                if ((!isAll && loggedUserId == Guid.Empty) || latitude == default(decimal) || longitude == default(decimal))
                    throw new Exception("Invalid Data");

                List<SaplingViewModal> _saplings = new List<SaplingViewModal>();
                using (saplingEntities saplingEntites = new saplingEntities())
                {
                    _saplings = saplingEntites.Sapling.Where(w =>
                     ((w.Latitude >= (latitude + 2) || w.Latitude <= (latitude - 2))
                     || (w.Longitude >= (longitude + 2) || w.Longitude <= (longitude - 2))
                     )
                     ||
                     (isAll ? true : w.CreatedBy == loggedUserId)).AsEnumerable()
                    .Select(s => new SaplingViewModal
                    {
                        Id = s.Id,
                        IsMine = s.CreatedBy == loggedUserId,
                        Position = new decimal[2] { s.Latitude, s.Longitude },
                        TreeName = s.Tree != null ? s.Tree.Name : string.Empty

                    }).ToList()
                    ;

                }
                return _saplings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static SaplingDetailViewModal GetSapling(long id, Guid loggedUserId)
        {
            try
            {
                SaplingDetailViewModal _saplingDetail = new SaplingDetailViewModal();
                using (saplingEntities saplingEntites = new saplingEntities())
                {
                    var sd = saplingEntites.Sapling.Where(w => w.Id == id).FirstOrDefault();
                    var sapling = saplingEntites.Sapling.FirstOrDefault(w => w.Id == id);
                    _saplingDetail.Id = sapling.Id;
                    _saplingDetail.IsMine = false;
                    _saplingDetail.Position = new decimal[2] { sapling.Latitude, sapling.Longitude };
                    _saplingDetail.TreeName = sapling.Tree != null ? sapling.Tree.Name : string.Empty;
                    _saplingDetail.NickName = sapling.NickName;
                    _saplingDetail.PlantedBy = sapling.User.UserName.Substring(0, sapling.User.UserName.IndexOf("@")); // remove after @  
                    _saplingDetail.Description = sapling.Description;
                    _saplingDetail.Address = sapling.Address;
                    _saplingDetail.Photo = new List<string>();
                    foreach (var item in sapling.SaplingImage)
                    {
                        _saplingDetail.Photo.Add("data:image/png;base64,"+Convert.ToBase64String(item.Photo));
                    };
                }
                return _saplingDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool Save(SaplingsSaveDetails data, Guid loggedUserId)
        {

            bool success = false;
            using (saplingEntities saplingEntites = new saplingEntities())
            {
                Sapling sap = new Sapling();

                sap.Address = data.Address;
                sap.IsExists = data.IsExists;
                sap.Latitude = data.Latitude;
                sap.Longitude = data.Longitude;
                sap.NextActionText = data.NextActionText;
                sap.TreeId = data.TreeId;
                sap.NickName = data.NickName;

                if (data.Id == 0)
                {
              
                    sap.CreatedBy = loggedUserId;
                    sap.CreatedOn = DateTime.UtcNow;

                    //save
                    saplingEntites.Sapling.Add(sap);
                }
                else
                {
                    sap.ModifiedBy = loggedUserId;
                    sap.ModifiedOn = DateTime.UtcNow;
                    sap.Id = data.Id;

                    //Update
                    saplingEntites.Sapling.Attach(sap);
                    saplingEntites.Entry(sap).State = System.Data.Entity.EntityState.Modified;
                }

                saplingEntites.SaveChanges();
                success = true;
               
         
            }
            return success;
        }

    }
}
