using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    //This is the concrete builder 1
    class Apple : ICellPhoneBuilder
    {
        private CellPhone cellPhone = new CellPhone();
        public CellPhone GetCellPhone()
        {
            return cellPhone;
        }

        public void SetAccessories()
        {
            cellPhone.accessories.Add("Charger");
            cellPhone.accessories.Add("Earphone");
        }

        public void SetCamera()
        {
            cellPhone.camera = "12mp";
        }

        public void SetMemory()
        {
            cellPhone.memory = "128gb";
        }

        public void SetModel()
        {
            cellPhone.model = "Apple iPhone 10";
        }

        public void SetProcessor()
        {
            cellPhone.processor = "A11";
        }
    }
}
