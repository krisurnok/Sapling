using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapling.BL
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
        
    }
}
