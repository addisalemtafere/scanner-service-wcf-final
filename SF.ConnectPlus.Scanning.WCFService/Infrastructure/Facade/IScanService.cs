using ScannerWCFServiceLibrary.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerServiceLibrary.Infrastructure.Facade
{
    public interface IScanService
    {
        bool IsServiceInstalled(string versionNumber);
        IEnumerable<Source> GetScanningDevices();
        string Scan(string fileFormat, string scannerID);
    }
}
