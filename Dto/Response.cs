using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlacierApp
{
    public class Response
    {
        public string VaultARN { get; set; }
        public DateTime InventoryDate { get; set; }
        public Archive[] ArchiveList { get; set; }
    }
}
