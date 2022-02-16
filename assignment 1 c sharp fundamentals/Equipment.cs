using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_c_sharp_fundamentals
{
    public class Equipment
    {
        /// <summary>
        /// Constructor for the EquipmentCompartments dictionary
        /// </summary>
        public Dictionary<EquipmentCompartments, Items> Contents { get; set; }

        public Equipment()
        {
            Contents = new Dictionary<EquipmentCompartments, Items>();
         }

    }
}
