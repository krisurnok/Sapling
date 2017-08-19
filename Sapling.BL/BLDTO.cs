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
        public Decimal[,] Position { get; set; }
        public string TreeName { get; set; }
    }
}
