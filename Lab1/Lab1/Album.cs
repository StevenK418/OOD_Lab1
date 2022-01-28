using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Album
    {
        string Name { get; set; }
        DateTime Released { get; set; }
        public int YearsSinceRelease { get; set; }
        long Sales { get; set; }

        /// <summary>
        /// Parametrised contsructor. Initializes values on instantiation of 
        /// a given instance.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="released"></param>
        /// <param name="sales"></param>
        public Album(string name, DateTime released, long sales)
        {
            Name = name;
            Released = released;
            Sales = sales;

            //Get number of years since the year the album was released
            YearsSinceRelease = DateTime.Today.Year - released.Year;
        }

        /// <summary>
        /// Default constructor, takes no parameters. 
        /// </summary>
        public Album()
        {

        }

        /// <summary>
        /// Overrides the ToString method of the parent Object Class.
        /// </summary>
        /// <returns>Returns the album properties as a string.</returns>
        public override string ToString()
        {
            return string.Format($"{Name} {Released.Year} {YearsSinceRelease} {Sales}");
        }
    }
}
