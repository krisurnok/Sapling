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
                     || (w.Longitude >= (longitude + 2) || w.Longitude <= (longitude - 2)))
                     && (isAll ? true : w.CreatedBy == loggedUserId)).AsEnumerable()
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

        public static SaplingViewModal GetSapling(long id)
        {
            try
            {
                SaplingViewModal _saplings = new SaplingViewModal();
                using (saplingEntities saplingEntites = new saplingEntities())
                {
                    _saplings = saplingEntites.Sapling.Where(w => w.Id == id)
                    .Select(s => new SaplingViewModal
                    {
                        Id = s.Id,
                        IsMine = false,
                        Position = new decimal[2] { s.Latitude, s.Longitude },
                        TreeName = s.Tree != null ? s.Tree.Name : string.Empty

                    }).FirstOrDefault()
                    ;

                }
                return _saplings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
