using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_Office_3.Data
{
    public static class FileHelper
    {
        public static void WriteToFile(string filePath, string data)
        {
            // Write data in text file 
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(data);
            }
        }
    }
}
