using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class RockBand:Band
    {
        /// <summary>
        /// Parametrised constructor allowing initialization of properties on
        /// each instantiation of the class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="yearFormed"></param>
        /// <param name="members"></param>
        public RockBand(string name, DateTime yearFormed, string[] members) : base(name, yearFormed, members)
        {
            BandName = name;
            YearFormed = yearFormed;
            Members = members;
        }

        /// <summary>
        /// Overrides the ToString method of the parent Object Class.
        /// </summary>
        /// <returns>Returns the Band's Name and type as a string.</returns>
        public override string ToString()
        {
            return base.ToString() + " - Rock Band";
        }
    }
}
