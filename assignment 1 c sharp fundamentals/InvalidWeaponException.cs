using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_c_sharp_fundamentals
{
    public class InvalidWeaponException:Exception
    {

        /// <summary>
        /// Constructor for the InvalidWeaponException. The exception is used for the equip weapon function in the hero class
        /// </summary>
        public InvalidWeaponException()
        {
            
        }

        public InvalidWeaponException(string message) : base(message)
        {
        }

        public InvalidWeaponException(string message, Exception innerException)  : base(message, innerException)
        {
        }

        
    }
}
