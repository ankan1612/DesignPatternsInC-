using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    //This is the abstract builder 
    interface ICellPhoneBuilder
    {
        void SetModel();
        void SetProcessor();
        void SetMemory();
        void SetCamera();
        void SetAccessories();

        CellPhone GetCellPhone();
    }
}
