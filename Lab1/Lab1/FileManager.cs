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
        static FileStream fsObject = new FileStream(fileName, FileMode.Open, FileAccess.Write);
        static StreamWriter swObject = new StreamWriter(fsObject);
        public static readonly FileManager fileManager = new FileManager();

        public FileManager()
        {
            if(fileManager != null)
            {
                Console.WriteLine("Object already exists, no further instance required!");
            }
        }

        /// <summary>
        /// Writes the local data input by the user into the txt file.
        /// </summary>
        /// <param name="fileName"></param>
        public static void WriteTextFile(List<string> data)
        {
            Console.WriteLine("\n Writing local data to file \n");

            for (int i = 0; i < data.Count; i++)
            {
                if (data.Count <= 0)
                {
                    Console.WriteLine("\n No data found! No Data written to file! \n");
                }
                else
                {
                    swObject.WriteLine(data[i].ToString());
                }
            }
            //Close the connection with the file to release
            swObject.Close();
        }
    }
}
