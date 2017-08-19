﻿using Sapling.Model;
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

        public static SaplingDetailViewModal GetSapling(long id)
        {
            try
            {
                SaplingDetailViewModal _saplingDetail = new SaplingDetailViewModal();
                using (saplingEntities saplingEntites = new saplingEntities())
                {
                    _saplingDetail = saplingEntites.Sapling.Where(w => w.Id == id).AsEnumerable()
                    .Select(s => new SaplingDetailViewModal
                    {
                        Id = s.Id,
                        IsMine = false,
                        Position = new decimal[2] { s.Latitude, s.Longitude },
                        TreeName = s.Tree != null ? s.Tree.Name : string.Empty,
                        NickName = s.NickName,
                        Address = s.Address,
                        PlantedBy = s.User.UserName
                      
                    }).FirstOrDefault()
                    ;

                }
                return _saplingDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
