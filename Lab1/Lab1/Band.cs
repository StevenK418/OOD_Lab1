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
        public int YearFormed { get; set; }
        public string Members { get; set; }
        public List<Album> AlbumList { get; set; }

        public string BandType { get; set; }

        /// <summary>
        /// Parametrised constructor allowing initialization of properties on
        /// each instantiation of the class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="yearFormed"></param>
        /// <param name="members"></param>
        public Band(string name, int yearFormed, string members, string bandType)
        {
            BandName = name;
            YearFormed = yearFormed;
            Members = members;
            AlbumList = new List<Album>();
            BandType = bandType;
        }

        /// <summary>
        /// Default constructor, takes no parameters. 
        /// </summary>
        public Band():this("Unkown", 1960, "Unkown", "unkown")
        {

        }

        /// <summary>
        /// Implements the CompareTo Method as
        /// </summary>
        /// <param name="o"></param>
        /// <returns>Returns the rsult of the comparison as an int.</returns>
        public int CompareTo(object o)
        {
            Band otherBand = (Band) o;
            return this.BandName.CompareTo(otherBand.BandName);
        }

        /// <summary>
        /// Overrides the ToString method of the parent Object Class. 
        /// And displays the band name a given instance. 
        /// </summary>
        /// <returns>Returns the band ame as a string</returns>
        public override string ToString()
        {
            return BandName;
        }
    }
}
