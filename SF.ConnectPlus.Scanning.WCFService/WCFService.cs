using System;
using System.Collections.Generic;
using ScannerServiceLibrary.Infrastructure.Facade;
using ScannerServiceLibrary.Infrastructure.Services;
using ScannerWCFServiceLibrary.Infrastructure.Models;

namespace ScannerWCFServiceLibrary
{
    public class WCFService : IWCFService
    {
        private readonly IScanService _scanningService;
        public WCFService()
        {
            _scanningService = new ScanService();
        }

        public bool IsServiceInstalled(string versionNumber)
        {
            return _scanningService.IsServiceInstalled(versionNumber);
        }
        public IEnumerable<Source> GetScanningDevices()
        {
            return _scanningService.GetScanningDevices();
        } 

        public string Scan(string fileFormat, string scannerID)
        {
            return _scanningService.Scan(fileFormat, scannerID);
        }
    }
}
