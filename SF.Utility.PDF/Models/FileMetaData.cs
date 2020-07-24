using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Utility.PDF.Models
{
    public class FileMetaData
    {
        public string Folder { get; set; }
        public string FileName { get; set; }
        public int Order { get; set; }
        public byte[] Thumbnail { get; set; }
        
    }
}
