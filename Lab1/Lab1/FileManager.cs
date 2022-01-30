using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class FileManager
    {
        static string fileName = "BandData.txt";
   
        /// <summary>
        /// Writes the data held within a given list into the txt file.
        /// </summary>
        /// <param name="fileName"></param>
        public void WriteTextFile(List<string> data)
        {
            //Write the data stored in the list to the file (Clearing existing data first rather than appending)
            using (StreamWriter file = new StreamWriter(fileName, false))
            {
                for (int i = 0; i < data.Count; i++)
                {
                    if (data.Count <= 0)
                    {
                        Console.WriteLine("\n No data found! No Data written to file! \n");
                    }
                    else
                    {
                        file.WriteLine(data[i].ToString());
                    }
                }
                //Close the connection with the file to release
                file.Close();
            }

           
        }
    }
}
