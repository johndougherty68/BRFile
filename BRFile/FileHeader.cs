using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRFile
{
    public class FileHeader:BRRecordBase
    {
        private string senderIdentification;
        private string receiverIdentification;
        private string fileCreationDate;
        private string fileCreationTime;
        private string fileIdentificationNumber;
        private int physicalRecordLength;
        private int blockSize;
        private string versionNumber;

        public override string RecordCode
        {
            get
            {
                return "01";
            }
        }

        public string SenderIdentification
        {
            get
            {
                return senderIdentification;
            }

            set
            {
                senderIdentification = value;
            }
        }

        public string ReceiverIdentification
        {
            get
            {
                return receiverIdentification;
            }

            set
            {
                receiverIdentification = value;
            }
        }

        public string FileCreationDate
        {
            get
            {
                return fileCreationDate;
            }

            set
            {
                fileCreationDate = value;
            }
        }

        public string FileCreationTime
        {
            get
            {
                return fileCreationTime;
            }

            set
            {
                fileCreationTime = value;
            }
        }

        public string FileIdentificationNumber
        {
            get
            {
                return fileIdentificationNumber;
            }

            set
            {
                fileIdentificationNumber = value;
            }
        }

        public int PhysicalRecordLength
        {
            get
            {
                return physicalRecordLength;
            }

            set
            {
                physicalRecordLength = value;
            }
        }

        public int BlockSize
        {
            get
            {
                return blockSize;
            }

            set
            {
                blockSize = value;
            }
        }

        public string VersionNumber
        {
            get
            {
                return "2";
            }
        }

    }
}
