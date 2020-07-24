using ScannerWCFServiceLibrary.Infrastructure.Models;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ScannerWCFServiceLibrary
{
    [ServiceContract(SessionMode = SessionMode.NotAllowed)]
    public interface IWCFService
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
        UriTemplate = "IsServiceInstalled?versionNumber={versionNumber}",
                        BodyStyle = WebMessageBodyStyle.Wrapped,
                        ResponseFormat = WebMessageFormat.Json,
                        RequestFormat = WebMessageFormat.Json
                   )]
        bool IsServiceInstalled(string versionNumber);

        [OperationContract]
        [WebInvoke(Method = "GET",
                        UriTemplate = "GetScanningDevices",
                        BodyStyle = WebMessageBodyStyle.Wrapped,
                        RequestFormat = WebMessageFormat.Json,
                        ResponseFormat = WebMessageFormat.Json)]
        IEnumerable<Source> GetScanningDevices();


        [OperationContract]
        [WebInvoke(Method = "GET",
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "/Scan?fileFormat={fileFormat}&scannerID={scannerID}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json)]
        string Scan(string fileFormat, string scannerID);

    }
}
