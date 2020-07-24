using ScannerServiceLibrary.Infrastructure.Facade;
using ScannerWCFServiceLibrary.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerServiceLibrary.Infrastructure.Services
{
    public class ScanService : IScanService
    {

        public bool IsServiceInstalled(string versionNumber)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Source> GetScanningDevices()
        {
            throw new NotImplementedException();
        }

        public string Scan(string fileFormat, string scannerID)
        {
            throw new NotImplementedException();
        }
    }
}
