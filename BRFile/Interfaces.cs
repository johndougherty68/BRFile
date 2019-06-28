using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRFile
{
    interface IRenderable
    {
        string Render();
    }

    interface IValidatable
    {
        bool IsValid();
    }
}
