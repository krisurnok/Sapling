using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaplingBL.BL
{
    public class SaplingViewModal
    {
        public long Id { get; set; }
        public bool IsMine { get; set; }
        public decimal[] Position { get; set; }
        public string TreeName { get; set; }
        public bool IsAll { get; set; }
    }

    public class SaplingDetailViewModal
    {
        public long Id { get; set; }
        public bool IsMine { get; set; }
        public decimal[] Position { get; set; }
        public string TreeName { get; set; }
        public string NickName { get; set; }
        public string PlantedBy { get; set; }
        public List<String> Photo { get; set; }
        public string Address { get; set; }
        public string Description { get; internal set; }
        public List<MaintanceViewModal> MaintanceList { get; set; }
    }
    public class MaintanceViewModal
    {
        public long Id { get; set; }
        public long SaplingId { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> ActionId { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
    }

    public class SaplingsSaveDetails
    {
        public long Id { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public int? TreeId { get; set; }
        public string NickName { get; set; }
        public string PlantedBy { get; set; }
        public string ReasonForNotExists { get; set; }
        public string Address { get; set; }

        public string NextActionText { get; set; }
        public string Description { get; set; }
        public bool IsExists { get; set; }   

    }
}
