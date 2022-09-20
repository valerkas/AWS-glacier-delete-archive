using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlacierApp
{
    public class Archive
    {
        public string ArchiveId { get; set; }
        public string ArchiveDescription { get; set; }
        public DateTime CreationDate { get; set; }
        public int Size { get; set; }
        public string SHA256TreeHash { get; set; }
    }
}
