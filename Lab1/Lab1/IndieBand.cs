using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class IndieBand:Band
    {
        /// <summary>
        /// Overrides the ToString method of the parent Object Class.
        /// </summary>
        /// <returns>Returns the Band's Name and type as a string.</returns>
        public override string ToString()
        {
            return base.ToString() + $" - {BandType} Band";
        }
    }
}
