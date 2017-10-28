using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    //This is the director class
    class CellPhoneCreator
    {
        private ICellPhoneBuilder cellPhone;

        public CellPhoneCreator(ICellPhoneBuilder cellPhone)
        {
            this.cellPhone = cellPhone;
        }

        public void CreateCellPhone()
        {
            cellPhone.SetModel();
            cellPhone.SetProcessor();
            cellPhone.SetCamera();
            cellPhone.SetMemory();
            cellPhone.SetAccessories();
        }

        public CellPhone GetCellPhone()
        {
            return cellPhone.GetCellPhone();
        }
    }
}
