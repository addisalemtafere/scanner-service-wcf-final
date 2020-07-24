using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF.Utility.PDF.Models;

namespace SF.Utility.PDF
{
    public class PDFService : IPDFService
    {
        public byte[] GetFile(FileMetaData fileMetaData)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileMetaData> GetLoanFiles(string loanNumber)
        {
            throw new NotImplementedException();
        }

        public byte[] MergeFiles(string loanNumber, IEnumerable<FileMetaData> files)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileMetaData> MoveFiles(string loanNumber, FileMetaData sourceFile, FileMetaData destinationFile)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FileMetaData> ReorderFiles(string loanNumber, IEnumerable<FileMetaData> files)
        {
            throw new NotImplementedException();
        }
    }
}
