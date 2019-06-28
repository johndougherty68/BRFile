using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRFile
{
    public class TransactionDetail : BRRecordBase
    {
        private string typeCode;
        private string amount;
        private string fundsType;
        private string bankReferenceNumber;
        private string customerReferenceNumber;
        private string text;

        public override string RecordCode
        {
            get
            {
                return "16";
            }
        }

        public string TypeCode
        {
            get
            {
                return typeCode;
            }

            set
            {
                typeCode = value;
            }
        }

        public string Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string FundsType
        {
            get
            {
                return fundsType;
            }

            set
            {
                fundsType = value;
            }
        }

        public string BankReferenceNumber
        {
            get
            {
                return bankReferenceNumber;
            }

            set
            {
                bankReferenceNumber = value;
            }
        }

        public string CustomerReferenceNumber
        {
            get
            {
                return customerReferenceNumber;
            }

            set
            {
                customerReferenceNumber = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public TransactionDetail() { }

        public TransactionDetail(string inputLine)
        {
            try
            {
                string[] items = inputLine.Split(',');
                this.TypeCode = items[1];
                this.Amount = items[2];
                this.FundsType = items[3];
                this.BankReferenceNumber = items[4];
                this.CustomerReferenceNumber = items[5];
                this.Text = items[6];
            }
            catch(Exception ex)
            {

            }
        }
    }
}
