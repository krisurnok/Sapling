using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapling.BL
{
    public class SaplingListViewModal
    {
        public long Id { get; set; }
        public bool IsMine { get; set; }
        public int[][] Position { get; set; }
    }
}
