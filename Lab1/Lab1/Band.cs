using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    abstract class Band:IComparable
    {
        public string BandName { get; set; }
        public DateTime YearFormed { get; set; }
        public string[] Members { get; set; }

        /// <summary>
        /// Parametrised constructor allowing initialization of properties on
        /// each instantiation of the class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="yearFormed"></param>
        /// <param name="members"></param>
        public Band(string name, DateTime yearFormed, string[] members)
        {
            BandName = name;
            YearFormed = yearFormed;
            Members = members;
        }

        /// <summary>
        /// Default constructor, takes no parameters. 
        /// </summary>
        public Band()
        {

        }

        /// <summary>
        /// Implements the CompareTo Method as
        /// </summary>
        /// <param name="o"></param>
        /// <returns>Returns the rsult of the comparison as an int.</returns>
        public int CompareTo(object o)
        {
            int result = 0;
            //TODO: Run comparison here
            return result;
        }

        /// <summary>
        /// Overrides the ToString method of the parent Object Class. 
        /// And displays the type of a given instance. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.GetType().ToString();
        }
    }
}
