using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIAS_Logic
{
    public static class DataLogger
    {
        public static void Log(StringBuilder msg)
        {
            string naglowek = string.Empty;
            FileInfo file = new FileInfo(@"C:\Temp\logs.csv");
            if (!file.Exists)
            {
                file.Directory.Create();
                naglowek= "Query,Database,Time,Rows";
            }
                

            using (StreamWriter writer = file.AppendText())
            {
                if (!string.IsNullOrEmpty(naglowek))
                    writer.WriteLine(naglowek);
                writer.WriteLine(msg);
            }
        }
    }
}
