using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1_c_sharp_fundamentals
{
    public class InvalidArmorException : Exception
    {

        /// <summary>
        /// Constructor for the InvalidArmorException. The exception is used for the equip armor function in the hero class
        /// </summary>
        public InvalidArmorException()
        {

        }

        public InvalidArmorException(string message) : base(message)
        {
        }

        public InvalidArmorException(string message, Exception innerException) : base(message, innerException)
        {
        }


    }
}
