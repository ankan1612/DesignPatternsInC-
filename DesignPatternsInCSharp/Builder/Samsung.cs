using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsInCSharp.Builder
{
    //This is concrete builder 2
    class Samsung : ICellPhoneBuilder
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
            cellPhone.accessories.Add("VR");
        }

        public void SetCamera()
        {
            cellPhone.camera = "16mp";
        }

        public void SetMemory()
        {
            cellPhone.memory = "64gb";
        }

        public void SetModel()
        {
            cellPhone.model = "Samsung S8";
        }

        public void SetProcessor()
        {
            cellPhone.processor = "Qualcomm SnapDragon 835";
        }
    }
}
