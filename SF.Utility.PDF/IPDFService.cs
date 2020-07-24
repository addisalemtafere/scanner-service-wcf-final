using SF.Utility.PDF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF.Utility.PDF
{
    public interface IPDFService
    {
        IEnumerable<FileMetaData> GetLoanFiles(string loanNumber);
        byte[] GetFile(FileMetaData fileMetaData);
        byte[] MergeFiles(string loanNumber, IEnumerable<FileMetaData> files);
        IEnumerable<FileMetaData> MoveFiles(string loanNumber, FileMetaData sourceFile, FileMetaData destinationFile);
        IEnumerable<FileMetaData> ReorderFiles(string loanNumber, IEnumerable<FileMetaData> files);
    }
}
