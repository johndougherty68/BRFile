using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRFile
{
    public abstract class BRRecordBase: IValidatable, IRenderable
    {
        public List<Exception> Errors = new List<Exception>();

        public abstract string RecordCode
        {
            get;
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public string Render()
        {
            throw new NotImplementedException();
        }
    }
}
