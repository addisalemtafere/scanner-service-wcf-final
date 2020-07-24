using ScannerWCFServiceLibrary.Infrastructure.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerWCFServiceLibrary.Infrastructure.Models
{
    public sealed class Source
    {
        public string Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public SourcePlatform Platform
        {
            get;
            set;
        }

        public DsmVersion Version
        {
            get;
            set;
        }

        public bool IsDefault
        {
            get;
            set;
        }
    }
}
